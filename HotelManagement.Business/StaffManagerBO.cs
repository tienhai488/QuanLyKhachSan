namespace HotelManagement.Business
{
    using HotelManagement.Data.Access;
    using HotelManagement.Data;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using HotelManagement.Data.Transfer;
    using HotelManagement.Ultils;
    using Microsoft.EntityFrameworkCore;

    public class StaffManagerBO
    {
        private static object syncKey = new();
        private static StaffManagerBO? bo;
        public static StaffManagerBO Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new StaffManagerBO();
                    }
                return bo;
            }
        }

        private Staff? selectedStaff;
        public Staff? SelectedStaff
        {
            get => selectedStaff;
            set
            {
                selectedStaff = value;
                if (value != null)
                {
                    bool candel = true;
                    if (candel)
                    {
                        using (var dao = new InvoiceDAO())
                        {
                            if (dao.HasStaffId(value.Id))
                                canDelete = false;
                        }
                    }
                    if (candel)
                    {
                        using (var dao = new ReservationDAO())
                        {
                            if (dao.HasStaffId(value.Id))
                                canDelete = false;
                        }
                    }
                    canSelectedAccounts = (from a in accounts
                                           where !a.Linked && a.Uid != 0 || a.Uid == value.AccountId
                                           select a).ToList();
                    //canDelete = value.CanDelete;
                    canDelete = candel;
                }
                else
                {
                    canSelectedAccounts = null;
                    canDelete = false;
                }
            }
        }

        private BigInteger usableUid;
        private IList<Staff>? staffs, lookedUpStaffs;
        public IList<Staff> Staffs
        {
            get
            {
                if (lookedUpStaffs != null)
                    return lookedUpStaffs;

                if (staffs == null)
                    lock (syncKey)
                    {
                        if (staffs == null)
                            LoadData();
                    }
                return staffs!;
            }
        }
        private IList<Role>? roles;
        public IList<Role> Roles
        {
            get
            {
                if (roles == null)
                    lock (syncKey)
                    {
                        if (roles == null)
                            LoadData();
                    }
                return roles!;
            }
        }
        private IList<PermissionGroup>? groups;
        public IList<PermissionGroup> Groups
        {
            get
            {
                if (groups == null)
                    lock (syncKey)
                    {
                        if (groups == null)
                            LoadData();
                    }
                return groups!;
            }
        }
        private IList<Account>? accounts, canSelectedAccounts;
        public IList<Account> Accounts
        {
            get
            {
                if (canSelectedAccounts != null)
                    return canSelectedAccounts;

                if (accounts == null)
                    lock (syncKey)
                    {
                        if (accounts == null)
                            LoadData();
                    }
                return accounts!;
            }
        }

        public bool Searching
        {
            get => lookedUpStaffs != null;
            set
            {
                if (lookedUpStaffs != null == value) return;
                lookedUpStaffs = value ? new List<Staff>(Staffs) : null;
            }
        }

        private bool creating;

        public void CreateStaff()
        {
            if (Searching) return;
            SelectedStaff = new(usableUid) { Birthday = DateOnly.FromDateTime(DateTime.Now) };
            creating = true;
        }

        public void LookupStaff(string text)
        {
            if (!Searching) return;
            var lookedUp = lookedUpStaffs;
            if (lookedUp == null) return;
            lookedUp.Clear();
            var staffs = this.staffs;
            if (staffs == null) return;
            IDictionary<BigInteger, Staff> dict
                = new Dictionary<BigInteger, Staff>();
            foreach (var sa in staffs)
                dict.Add(sa.Id, sa);

            foreach (var kv in dict)
            {
                if (kv.Value.IdString()!.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.FullName.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.GenderString!.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.CitizenId.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Phone.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Address.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Birthday.ToString(Configs.formatBirthday)!.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }

            foreach (var kv in dict)
            {
                if (kv.Value.Salary.ToString().Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Resign && "Đã nghỉ việc".Contains(text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Role?.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase) ?? false)
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Account?.UserName.Contains(text, StringComparison.CurrentCultureIgnoreCase) ?? false)
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
            foreach (var kv in dict)
            {
                if (kv.Value.Group?.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase) ?? false)
                {
                    lookedUp.Add(kv.Value);
                    dict.Remove(kv.Key);
                }
            }
        }

        private bool canDelete;
        public bool CanDelete => canDelete;

        public void DeleteStaff()
        {
            if (Searching) return;
            if (SelectedStaff == null) return;
            lock (syncKey)
            {
                var pg = SelectedStaff;
                if (canDelete)
                {
                    using (var dao = new StaffDAO())
                    {
                        dao.Remove(pg);
                        dao.SaveChanges();
                        LoadData(dao);
                    }
                    SelectedStaff = null;
                }
            }
        }

        public void AcceptEdit()
        {
            if (Searching) return;
            if (SelectedStaff == null) return;
            lock (syncKey)
            {
                var staff = SelectedStaff;
                if (staff != null)
                {
                    using (var dao = new StaffDAO())
                    {
                        var entry = dao.Update(staff);
                        if (creating)
                        {
                            entry.State = EntityState.Added;
                            creating = false;
                        }
                        dao.ChangeTracker.DetectChanges();
                        dao.SaveChanges();
                        LoadData(dao);
                    }
                }
            }
        }

        public void CancelEdit()
        {
            if (Searching) return;
            if (creating)
            {
                SelectedStaff = null;
                creating = false;
            }
        }

        private void LoadData(StaffDAO? dao = null)
        {
            if (dao != null)
            {
                var sd = dao.Staffs.ToList();
                sd.Sort(Staff.NameIDComparison);
                staffs = sd;
                var rd = dao.Roles.ToList();
                rd.Sort(Role.NameIDComparison);
                roles = rd;
                var ad = dao.Accounts.ToList();
                ad.Sort(Account.UserNameComparison);
                accounts = ad;
                var gd = dao.Groups.ToList();
                gd.Sort(PermissionGroup.NameComparison);
                groups = gd;
                usableUid = dao.UsableId;
            }
            else
            {
                using (dao = new StaffDAO())
                {
                    LoadData(dao);
                }
            }
        }

        public bool IsValidName(string? name) => !string.IsNullOrEmpty(name);
        public bool IsValidAddress(string? name) => !string.IsNullOrEmpty(name);
        public bool IsValidCitizenId(string? name)
            => name != null && name.Length is 9 or 12 && ulong.TryParse(name, out _);
        public bool IsValidPhone(string? name)
            => name != null && name.Length is 10 or 11 && ulong.TryParse(name, out _);

        private StaffManagerBO() { }
    }
}
