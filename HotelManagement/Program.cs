using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.GUI;
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
            //using (var dao = new AccountDAO())
            //{
            //    if ((from a in dao.Set<Account>()
            //         where a.Uid == BigInteger.Zero
            //         select a).Any())
            //    {
            //        dao.Update(new Account(0)
            //        {
            //            UserName = "root99",
            //            Password = "Hello|11"
            //        });
            //    }
            //    else
            //    {
            //        dao.Add(new Account(0)
            //        {
            //            UserName = "root99",
            //            Password = "Hello|11"
            //        });
            //    }
            //    dao.SaveChanges();
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);

            Application.Run(new MainUI());

        }
    }
}