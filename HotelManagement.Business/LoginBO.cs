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
            using (var dao = new StaffEFCoreDAO())
            {
                var account = (from a in dao.Set<Account>()
                               where a.UserName == UserName
                               && a.Password == Password
                               select a).FirstOrDefault();
                if (account == null || account.Disabled) return false;
                if (account.Uid != 0)
                {
                    var staff = (from s in dao.Set<Staff>()
                                 where s.AccountId == account.Uid
                                 select s).FirstOrDefault();
                    if (staff == null) return false;
                    else accessable = staff;
                }
                else accessable = account;
                return true;
            }
        }

        private LoginBO() { }
    }
}
