//namespace HotelManagement.Data.Access
//{
//    using Microsoft.EntityFrameworkCore;

//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Threading.Tasks;
//    using System.Windows.Forms;

//    public class StatisticsDAO2
//    {
//        public StatisticsDAO2()
//        {
//        }

//        public IEnumerable<(int, double)> RevenueByMonthStatistic()
//        {
//            using (var dao = new InvoiceDAO())
//            {
//                //return (from i in dao.Set<Invoice>()
//                //        where i.PaidTime != null
//                //        let k = i.PaidTime!.Value
//                //        let d = k.Month - 1 + k.Year * 12
//                //        group i by d into rm
//                //        select ValueTuple.Create(rm.Key, (from r in rm select r.TotalDue).Sum()))
//                //        .ToList();
//            }
//        }

//        public IEnumerable<(string, double)> RoomRevenueByTypeStatistic(int start, int end)
//        {
//            //IEnumerable<(string, int)> query;
//            //using (var dao = new InvoiceDAO())
//            //{
//            //    query = (from i in dao.Set<Invoice>().Include(inv => inv.UseServiceDetails).ToList()
//            //            where i.PaidTime != null
//            //            let k = i.PaidTime!.Value
//            //            let d = k.Month - 1 + k.Year * 12
//            //            where d >= start && d <= end
//            //            from rd in i.RentRooms
//            //            group rd by rd.RoomId into rts
//            //            select ValueTuple.Create(rts.Key, (from t in rts select (t.EndTime - t.StartTime).Hours).Sum())).ToList();
//            //}

//            //IEnumerable<(string, int)> query2;
//            //using (var dao = new RoomDAO())
//            //{
//            //    query2 = (from r in dao.Rooms.Include(r => r.RoomType).ToList()
//            //              join rt in query on r.Id equals rt.Item1
//            //              group rt by r.RoomTypeId into roomTypeHours
//            //              select (roomTypeHours.Key, (from t in roomTypeHours select t.Item2).Sum()));
//            //}

//            //using (var dao = new RoomDAO())
//            //{
//            //    return from t in dao.RoomTypes.ToList()
//            //           join th in query2 on t.Id equals th.Item1
//            //           select (t.Name, t.UnitPrice * th.Item2);
//            //}
//        }

//        public IEnumerable<(string, double)> ServiceRevenueByNameStatistic(int start, int end)
//        {
//            //IEnumerable<(string, int)> query;
//            //using (var dao = new InvoiceDAO())
//            //{
//            //    query = from i in dao.Set<Invoice>().Include(inv => inv.UseServiceDetails).ToList()
//            //            where i.PaidTime != null
//            //            let k = i.PaidTime!.Value
//            //            let d = k.Month - 1 + k.Year * 12
//            //            where d >= start && d <= end
//            //            from sd in i.UseServices
//            //            group sd by sd.ServiceId into ss
//            //            select ValueTuple.Create(ss.Key, (from t in ss select t.Quantity).Sum());
//            //}

//            //using (var dao = new ServiceDAO())
//            //{
//            //    return from t in dao.Services.ToList()
//            //           join th in query on t.Id equals th.Item1
//            //           select (t.Name, t.UnitPrice * th.Item2);
//            //}
//        }
//    }
//}
