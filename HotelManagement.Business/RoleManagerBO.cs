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

    public class RoleManagerBO
    {
        private static object syncKey = new();
        private static RoleManagerBO? bo;
        public static RoleManagerBO Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new RoleManagerBO();
                    }
                return bo;
            }
        }

        private Role? selectedRole;
        public Role? SelectedRole
        {
            get => selectedRole;
            set
            {
                selectedRole = value;
                if (value != null)
                {
                    using (var dao = new StaffDAO())
                    {
                        canDelete = !dao.HasStaffWithRole(value.Id);
                    }
                }
                else canDelete = false;
            }
        }

        private BigInteger usableUid;
        private IList<Role>? roles, lookedUpRoles;
        public IList<Role> Roles
        {
            get
            {
                if (lookedUpRoles != null)
                    return lookedUpRoles;

                if (roles == null)
                    lock (syncKey)
                    {
                        if (roles == null)
                            using (var dao = new RoleDAO())
                            {
                                roles = dao.Roles.ToList();
                                usableUid = dao.UsableId;
                            }
                    }
                return roles;
            }
        }

        public bool Searching
        {
            get => lookedUpRoles != null;
            set
            {
                if (lookedUpRoles != null == value) return;
                lookedUpRoles = value ? new List<Role>(Roles) : null;
            }
        }

        private bool creating;

        public void CreateRole()
        {
            if (Searching) return;
            SelectedRole = new(usableUid);
            creating = true;
        }

        public void LookupRole(string text)
        {
            if (!Searching) return;
            var lookedUp = lookedUpRoles;
            if (lookedUp == null) return;
            lookedUp.Clear();
            var roles = this.roles;
            if (roles == null) return;
            foreach (var item in roles)
            {
                if (item.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase))
                    lookedUp.Add(item);
            }
        }

        private bool canDelete;
        public bool CanDelete => canDelete;

        public void DeleteRole()
        {
            if (Searching) return;
            if (SelectedRole == null) return;
            lock (syncKey)
            {
                var pg = SelectedRole;
                if (canDelete)
                {
                    using (var dao = new RoleDAO())
                    {
                        dao.Remove(pg);
                        dao.SaveChanges();
                        roles = dao.Roles.ToList();
                        usableUid = dao.UsableId;
                    }
                    SelectedRole = null;
                }
            }
        }

        public void AcceptEdit()
        {
            if (Searching) return;
            if (SelectedRole == null) return;
            lock (syncKey)
            {
                var role = SelectedRole;
                if (role != null)
                {
                    using (var dao = new RoleDAO())
                    {
                        if (creating)
                        {
                            dao.Add(role);
                            creating = false;
                        }
                        else dao.Update(role);
                        dao.SaveChanges();
                        roles = dao.Roles.ToList();
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
                SelectedRole = null;
                creating = false;
            }
        }

        public bool IsValidName(string? name) => !string.IsNullOrWhiteSpace(name);

        private RoleManagerBO() { }
    }
}
