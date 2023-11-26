namespace HotelManagement.Business
{
    using HotelManagement.Data;

    using System;
    using System.Collections.Generic;

    public class GrantingPermissionsBO
    {
        private static readonly object syncKey = new();
        private static GrantingPermissionsBO? bo;
        public static GrantingPermissionsBO Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new GrantingPermissionsBO();
                    }
                return bo;
            }
        }

        private Account? account;
        private PermissionGroup? group;
        private IAccessable? selectedAccessable;

        public Account? Account
        {
            get => account;
            set
            {
                if (!Editing) return;
                account = value;
            }
        }
        public PermissionGroup? Group
        {
            get => group;
            set
            {
                if (!Editing) return;
                group = value;
            }
        }
        public IAccessable? SelectedAccessable
        {
            get => selectedAccessable;
            set
            {
                selectedAccessable = value;
                if (value != null)
                {
                    account = value.Account;
                    group = value.Group;
                }
                else
                {
                    account = null;
                    group = null;
                }
            }
        }

        public bool Editing { get; set; }

        public void SavePermissions(IDictionary<Permission, bool> permissions)
        {
            var a = SelectedAccessable;
            if (a != null && Editing)
            {
                var e = a.Edit();
                foreach (var perm in permissions)
                    e.SetGranted(perm.Key, perm.Value);
            }
        }

        public static string GetPermissionName(Permission x) => x switch
        {
            Permission.ReadAccount => "Đọc tài khoản",
            Permission.WriteAccount => "Ghi tài khoản",
            Permission.ReadPermissionGroup => "Đọc nhóm quyền",
            Permission.WritePermissionGroup => "Ghi nhóm quyền",
            Permission.GrantPermission => "Cấp quyền",
            Permission.ReadRole => "Đọc chức vụ",
            Permission.WriteRole => "Ghi chức vụ",
            Permission.ReadStaff => "Đọc nhân viên",
            Permission.WriteStaff => "Ghi nhân viên",
            Permission.ReadService => "Đọc dịch vụ",
            Permission.WriteService => "Ghi dịch vụ",
            Permission.ReadServiceType => "Đọc loại dịch vụ",
            Permission.WriteServiceType => "Ghi loại dịch vụ",
            Permission.ReadRoom => "Đọc phòng",
            Permission.WriteRoom => "Ghi phòng",
            Permission.ReadRoomType => "Đọc loại phòng",
            Permission.WriteRoomType => "Ghi loại phòng",
            Permission.ReadConvenient => "Đọc tiện nghi",
            Permission.WriteConvenient => "Ghi tiện nghi",
            Permission.ReadCustomer => "Đọc khách hàng",
            Permission.WriteCustomer => "Ghi khách hàng",
            Permission.UpdateReservation => "Cập nhật đặt phòng",
            Permission.UpdateRoomDetails => "Cập nhật thuê phòng",
            Permission.UpdateServiceDetails => "Cập nhật dùng dịch vụ",
            Permission.CancelServiceDetails => "Hủy dùng dịch vụ",
            Permission.UpdateInvoice => "Cập nhật hóa đơn",
            _ => "Không xác định",
        };

        public static IAccessable CreateExampleStaff()
        {
            IAccessable s = new Staff(1234UL)
            {
                FullName = "Nguyen Thi C",
                Gender = Staff.GenderMale,
                Birthday = new(2000, 3, 18),
                CitizenId = "012345678901"
            };
            s.Edit().Assign(CreateExampleAccount().Account, CreateExamplePermissionGroup().Group);
            return s;
        }

        public static IAccessable CreateExampleAccount()
        {
            IAccessable a = new Account(4321UL)
            {
                UserName = "abcdxyz",
                Password = "He11o+-World",
                Linked = false
            };
            IAccessable.Editor e = a.Edit();
            e.SetGranted(Permission.UpdateInvoice, true);
            e.SetGranted(Permission.ReadConvenient, true);
            e.SetGranted(Permission.WriteConvenient, true);
            return a;
        }

        public static IAccessable CreateExamplePermissionGroup()
        {
            IAccessable pg = new PermissionGroup(4321UL) { Name = "xyztabc" };
            IAccessable.Editor e = pg.Edit();
            e.SetGranted(Permission.GrantPermission, true);
            e.SetGranted(Permission.ReadStaff, true);
            e.SetGranted(Permission.WriteStaff, true);
            return pg;
        }

        private GrantingPermissionsBO() { }
    }
}
