using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.GUI;
using HotelManagement.Validations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System.Diagnostics;
using System.Numerics;

namespace HotelManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            VerifyRootAccountValid();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);

Application.Run(new LoginUI());
        }

        private static void VerifyRootAccountValid()
        {
            using (var dao = new AccountDAO())
            {
                var ra = new Account(0)
                {
                    UserName = "root99",
                    Password = "Hello|11"
                };

                var la = (from a in dao.Set<Account>().AsNoTracking()
                          where a.Uid == BigInteger.Zero
                          select a).FirstOrDefault();

                Func<Account, EntityEntry<Account>> update = dao.Update;
                if (la != null)
                {
                    string value;
                    if ((value = la.UserName).IsValidUserName())
                        ra.UserName = value;
                    if ((value = la.Password).IsValidPassword())
                        ra.Password = la.Password;
                }
                else update = dao.Add;
                update(ra);
                dao.SaveChanges();
            }
        }
    }
}