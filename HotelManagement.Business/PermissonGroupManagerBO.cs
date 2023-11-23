namespace HotelManagement.Business
{
    using HotelManagement.Data.Access;
    using HotelManagement.Data;
    using HotelManagement.Validations;

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class PermissonGroupManagerBO
    {
        private static object syncKey = new();
        private static PermissonGroupManagerBO? bo;
        public static PermissonGroupManagerBO Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new PermissonGroupManagerBO();
                    }
                return bo;
            }
        }

        private PermissionGroup? selectedGroup;
        public PermissionGroup? SelectedGroup
        {
            get => selectedGroup;
            set
            {
                selectedGroup = value;
                if (value != null)
                {
                    using (var dao = new StaffEFCoreDAO())
                    {
                        canDelete = !dao.HasStaffWithPermissionGroup(value.Id);
                    }
                }
                else canDelete = false;
            }
        }

        private BigInteger usableUid;
        private IList<PermissionGroup>? groups, lookedUpGroups;
        public IList<PermissionGroup> PermissionGroups
        {
            get
            {
                if (lookedUpGroups != null)
                    return lookedUpGroups;

                if (groups == null)
                    lock (syncKey)
                    {
                        if (groups == null)
                            using (var dao = new PermissionGroupEFCoreDAO())
                            {
                                groups = dao.PermissionGroups.ToList();
                                usableUid = dao.UsableId;
                            }
                    }
                return groups;
            }
        }

        public bool Searching
        {
            get => lookedUpGroups != null;
            set
            {
                if (lookedUpGroups != null == value) return;
                lookedUpGroups = value ? new List<PermissionGroup>(PermissionGroups) : null;
            }
        }

        private bool creating;

        public void CreateGroup()
        {
            if (Searching) return;
            SelectedGroup = new(usableUid);
            creating = true;
        }

        public void LookupGroup(string text)
        {
            if (!Searching) return;
            var lookedUp = lookedUpGroups;
            if (lookedUp == null) return;
            lookedUp.Clear();
            var groups = this.groups;
            if (groups == null) return;
            foreach (var item in groups)
            {
                if (item.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                    lookedUp.Add(item);
            }
        }

        private bool canDelete;
        public bool CanDelete => canDelete;

        public void DeleteGroup()
        {
            if (Searching) return;
            if (SelectedGroup == null) return;
            lock (syncKey)
            {
                var pg = SelectedGroup;
                if (canDelete)
                {
                    using (var dao = new PermissionGroupEFCoreDAO())
                    {
                        dao.Remove(pg);
                        dao.SaveChanges();
                        groups = dao.PermissionGroups.ToList();
                        usableUid = dao.UsableId;
                    }
                    SelectedGroup = null;
                }
            }
        }

        public void AcceptEdit()
        {
            if (Searching) return;
            if (SelectedGroup == null) return;
            lock (syncKey)
            {
                var group = SelectedGroup;
                if (group != null)
                {
                    using (var dao = new PermissionGroupEFCoreDAO())
                    {
                        if (creating)
                        {
                            dao.Add(group);
                            creating = false;
                        }
                        else dao.Update(group);
                        dao.SaveChanges();
                        groups = dao.PermissionGroups.ToList();
                        usableUid = dao.UsableId;
                    }
                }
            }
        }

        public void CancelEdit()
        {
            if (Searching) return;
            if (creating)
            {
                SelectedGroup = null;
                creating = false;
            }
        }

        public bool IsValidName(string? name) => name.IsValidName();

        private PermissonGroupManagerBO() { }
    }
}
