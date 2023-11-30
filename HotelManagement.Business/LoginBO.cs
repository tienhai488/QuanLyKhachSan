namespace HotelManagement.Business
{
    using HotelManagement.Data;
    using HotelManagement.Data.Access;
    using HotelManagement.Validations;

    using System.Linq;

    public class LoginBO
    {
        private static object syncKey = new();
        private static IAccessable? accessable;
        private static LoginBO? bo;
        public static Account? SignedInAccount => accessable?.Account;
        public static Staff? SignedInStaff => accessable as Staff;
        public static void SignOut() => accessable = null;
        public static bool IsPermissionGranted(Permission permission)
            => accessable?.IsPermissionGranted(permission) ?? false; // change to 'true' to test a form, 'false' on final build

        public static LoginBO Instance
        {
            get
            {
                if (bo == null) lock (syncKey)
                    {
                        bo ??= new LoginBO();
                    }
                return bo;
            }
        }

        public string? UserName { get; set; }
        public string? Password { get; set; }

        public bool IsValidUserName => UserName.IsValidUserName();
        public bool IsValidPassword => Password.IsValidPassword();

        public bool SignIn()
        {
            if (!IsValidUserName || !IsValidPassword) return false;
            Account? account = null!;
            using (var dao = new AccountDAO())
            {
                account = dao.SignIn(UserName!, Password!);
                if (account == null || account.Disabled) return false;
            }

            if (account.Uid == 0)
            {
                accessable = account;
                return true;
            }

            using (var dao = new StaffDAO())
            {
                var staff = dao.GetStaffWithAccountId(account.Uid);
                if (staff == null) return false;
                else accessable = staff;
                return true;
            }
        }

        private LoginBO() { }
    }
}
