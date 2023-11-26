namespace HotelManagement.Data
{
    using HotelManagement.Algorithms;

    using System;
    using System.Buffers.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Numerics;
    using System.Text;

    public enum Permission : ushort
    {
        ReadAccount = 0,
        WriteAccount = 1,
        ReadPermissionGroup = 2,
        WritePermissionGroup = 3,
        GrantPermission = 4,
        ReadRole = 5,
        WriteRole = 6,
        ReadStaff = 7,
        WriteStaff = 8,
        ReadService = 9,
        WriteService = 10,
        ReadServiceType = 11,
        WriteServiceType = 12,
        ReadRoom = 13,
        WriteRoom = 14,
        ReadRoomType = 15,
        WriteRoomType = 16,
        ReadConvenient = 17,
        WriteConvenient = 18,
        ReadCustomer = 19,
        WriteCustomer = 20,
        UpdateReservation = 21,
        UpdateRoomDetails = 22,
        UpdateServiceDetails = 23,
        CancelServiceDetails = 24,
        UpdateInvoice = 25
    } // Database limit 0-299

    public interface IAccessable
    {
        private static Comparer<Permission> comparer = Comparer<Permission>.Create(AccessableExtensions.Compare);

        Account? Account { get; }
        PermissionGroup? Group { get; }
        Editor Edit();

        public readonly struct Editor
        {
            public readonly IAccessable Instance;
            private readonly object helper;

            public delegate void Callback(ref Account? account, ref PermissionGroup? group);
            public Editor(IAccessable instance, Callback callback)
            {
                if (instance is Account || instance is PermissionGroup) throw new NotSupportedException();
                Instance = instance;
                helper = callback ?? throw new ArgumentNullException(nameof(callback));
            }

            internal Editor(IAccessable instance, IList<Permission> permissions)
            {
                Instance = instance;
                helper = permissions;
            }

            public void Assign(Account? account = null, PermissionGroup? group = null)
            {
                if (helper is not Callback callback) throw new NotSupportedException();
                Account? a = account;
                PermissionGroup? pg = group;
                callback(ref a, ref pg);
                if (a != null) a.Linked = false;
                if (account != null) account.Linked = true;
            }

            public void SetGranted(Permission permission, bool granted = true)
            {
                if (helper is IList<Permission> permissions)
                {
                    int index = permissions.BinarySearch(permission, comparer);
                    if (index >= 0 == granted) return;
                    if (!granted) permissions.RemoveAt(index);
                    else permissions.Insert(~index, permission);
                }
                else if (helper is Callback)
                {
                    IAccessable accessable = Instance.Group;
                    if (accessable is not null && accessable.IsPermissionGranted(permission) && granted) return;
                    accessable = Instance.Account;
                    if (accessable is not null && (!accessable.IsPermissionGranted(permission) || !granted))
                        accessable.Edit().SetGranted(permission, granted);
                }
                else throw new NotSupportedException();
            }
        }

        public abstract class Key : IAccessable
        {
            private readonly IList<Permission> permissions;
            public IEnumerable<Permission> Permissions => new ReadOnlyCollection<Permission>(permissions);
            public string SerializedPermissions
            {
                get
                {
                    byte[] bs = new byte[64];
                    for (int c = permissions.Count; c > 0;)
                    {
                        int i = (int)permissions[--c];
                        if (i >= 300) continue;
                        int x = i >> 3, y = (~i) & 7;
                        bs[x] = (byte)(bs[x] | (1 << y));
                    }
                    Base64.EncodeToUtf8InPlace(bs, 38, out int count);
                    if (count > 50) count = 50;
                    return Encoding.UTF8.GetString(bs, 0, count);
                }
                private set
                {
                    permissions.Clear();
                    byte[] bs = new byte[64];
                    Encoding.UTF8.GetBytes(value, bs);
                    Base64.DecodeFromUtf8InPlace(bs, out int count);
                    for (int i = 0; i < count; ++i)
                    {
                        if (bs[i] == 0) continue;
                        for (int j = 0; j < 8; ++j)
                        {
                            if (((bs[i] >> ((~j) & 7)) & 1) == 0) continue;
                            permissions.Add((Permission)(i << 3 | j));
                        }
                    }
                }
            }
            private protected Key() => permissions = new List<Permission>();
            private protected virtual Account? AsAccount() => null;
            private protected virtual PermissionGroup? AsPermissionGroup() => null;
            public bool IsPermissionGranted(Permission permission) => permissions.BinarySearch(permission, comparer) >= 0;
            Account? IAccessable.Account => AsAccount();
            PermissionGroup? IAccessable.Group => AsPermissionGroup();
            Editor IAccessable.Edit() => new(this, permissions);
        }
    }

    [Flags]
    public enum AccountState : byte
    {
        Linked = 0x01,
        Disabled = 0x02
    }

    public class Account : IAccessable.Key
    {
        private BigInteger uid;
        private string userName;
        private string password;
        private AccountState state;

        public BigInteger Uid
        {
            get => uid;
            private set
            {
                uid = value;
                if (uid == 0)
                {
                    var e = ((IAccessable)this).Edit();
                    foreach (var perm in Permissions)
                        e.SetGranted(perm);
                }
            }
        }
        public string UserName { get => userName; set => userName = value; }
        public AccountState State { get => state; private set => state = value; }
        public string Password { get => password ?? ""; set => password = value; }

        public bool Linked
        {
            get => (state & AccountState.Linked) == AccountState.Linked;
            set
            {
                if (value) state |= AccountState.Linked;
                else state &= ~AccountState.Linked;
            }
        }

        public bool Disabled
        {
            get => (state & AccountState.Disabled) == AccountState.Disabled;
            set
            {
                if (value) state |= AccountState.Disabled;
                else state &= ~AccountState.Disabled;
            }
        }

        public Account(BigInteger uid) => Uid = uid;

        public Account() { }

        private protected override Account AsAccount() => this;

        public static int UidComparison(Account x, Account y) => x.Uid.CompareTo(y.Uid);

        public static int UserNameComparison(Account x, Account y) => CultureInfo.CurrentCulture.CompareInfo.Compare(x.UserName, y.UserName);
    }

    public class PermissionGroup : IAccessable.Key
    {
        private BigInteger id;
        private string name;
        public BigInteger Id { get => id; private set => id = value; }
        public string Name { get => name; set => name = value; }
        public PermissionGroup(BigInteger id) => this.id = id;
        public PermissionGroup() { }
        private protected override PermissionGroup AsPermissionGroup() => this;
        public static int IdComparison(PermissionGroup x, PermissionGroup y) => x.Id.CompareTo(y.Id);
        public static int NameComparison(PermissionGroup x, PermissionGroup y) => CultureInfo.CurrentCulture.CompareInfo.Compare(x.Name, y.Name);
    }

    public static class AccessableExtensions
    {
        public static int Compare(this Permission x, Permission y) => ((ushort)x).CompareTo((ushort)y);

        public static bool IsPermissionGranted(this IAccessable accessable, Permission permission)
            => accessable is IAccessable.Key key ? key.IsPermissionGranted(permission)
            : accessable is not null && ((accessable.Group?.IsPermissionGranted(permission) ?? false)
                                    || (accessable.Account?.IsPermissionGranted(permission) ?? false));
    }
}
