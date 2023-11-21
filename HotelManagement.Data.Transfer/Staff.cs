namespace HotelManagement.Data
{
    using System;
    using System.Globalization;
    using System.Numerics;

    public class Role
    {
        private BigInteger id;
        private string name;

        public BigInteger Id { get => id; private set => id = value; }
        public string Name { get => name; set => name = value; }
        public Role(BigInteger id)
        {
            this.id = id;
        }
        public Role() { }
        public static int NameComparison(Role x, Role y) => CultureInfo.CurrentCulture.CompareInfo.Compare(x.Name, y.Name);
    }

    [Flags]
    public enum StaffState : int
    {
        None = 0,
        CanDelete = 0x80,
        Resign = 0x01 // nghỉ việc
    }

    public class Staff : IAccessable
    {
        public const bool GenderMale = true, GenderFemale = false;

        private BigInteger id;
        private BigInteger? roleId, accountId, groupId;
        private string fullName, address, citizenID, phone, imageLink;
        private bool gender;
        private double salary;
        private StaffState status;
        private DateOnly birthday;
        private Role? role;
        private Account? account;
        private PermissionGroup? group;

        public BigInteger Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string CitizenId { get => citizenID; set => citizenID = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateOnly Birthday { get => birthday; set => birthday = value; }
        public string Phone { get => phone; set => phone = value; }
        public string GenderString { get => gender == GenderMale ? "Male" : "Female"; }
        public double Salary { get => salary; set => salary = value; }
        public StaffState Status { get => status; private set => status = value; }
        public bool CanDelete
        {
            get => (status & StaffState.CanDelete) == StaffState.CanDelete;
            set => status = value ? status | StaffState.CanDelete : status & ~StaffState.CanDelete;
        }
        public bool Resign
        {
            get => (status & StaffState.Resign) == StaffState.Resign;
            set => status = value ? status | StaffState.Resign : status & ~StaffState.Resign;
        }
        public string ImageLink { get => imageLink; set => imageLink = value; }
        public BigInteger? RoleId { get => roleId; private set => roleId = value; }
        public BigInteger? AccountId { get => accountId; private set => accountId = value; }
        public BigInteger? GroupId { get => groupId; private set => groupId = value; }

        public Role? Role
        {
            get => role;
            private set
            {
                role = value;
            }
        }
        public Account? Account
        {
            get => account;
            private set
            {
                account = value;
            }
        }
        public PermissionGroup? Group
        {
            get => group;
            private set
            {
                group = value;
            }
        }

        public Staff(BigInteger id)
        {
            this.id = id;
        }
        
        public Staff() { }

        private void Edit(ref Account? account, ref PermissionGroup? group)
        {
            Account? a = account;
            account = this.account;
            this.account = a;
            PermissionGroup? pg = group;
            group = this.group;
            this.group = pg;
        }

        IAccessable.Editor IAccessable.Edit() => new(this, Edit);
    }
}
