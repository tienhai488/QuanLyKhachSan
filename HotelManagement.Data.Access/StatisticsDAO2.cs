namespace HotelManagement.Data.Access
{
    using Microsoft.EntityFrameworkCore;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StatisticsDAO2
    {
        public StatisticsDAO2()
        {
        }

        public IEnumerable<(int, double)> RevenueByMonthStatistic()
        {
            using (var dao = new InvoiceDAO())
            {
                return from rd in dao.RentRoomDetails.Include(rd => rd.Room).ThenInclude(r => r.RoomType)
                                        .Include(rd => rd.UseServiceDetails).ThenInclude(sd => sd.Service).ToList()
                       where rd.PaidTime != default
                       let k = rd.PaidTime
                       let d = k.Month - 1 + k.Year * 12
                       group rd by d into rm
                       let rr = (from r in rm
                                 let days = Math.Truncate((r.EndTime - r.StartTime).TotalDays) + 1
                                 select r.Room.RoomType.UnitPrice * days).Sum()
                       let sr = (from r in rm
                                 from sd in r.UseServiceDetails
                                 select sd.Service.UnitPrice * sd.Quantity).Sum()
                       let value = rr + sr
                       select ValueTuple.Create(rm.Key, value);
            }
        }

        public IEnumerable<(string, double)> RoomRevenueByTypeStatistic(int start, int end)
        {
            IEnumerable<(string, double)> query;
            using (var dao = new InvoiceDAO())
            {
                query = (from rd in dao.RentRoomDetails.Include(rd => rd.Room).ThenInclude(r => r.RoomType).ToList()
                         where rd.PaidTime != default
                         let k = rd.PaidTime
                         let d = k.Month - 1 + k.Year * 12
                         where d >= start && d <= end
                         group rd by rd.Room.RoomTypeId into rm
                         let value = (from r in rm
                                      let days = Math.Truncate((r.EndTime - r.StartTime).TotalDays) + 1
                                      select r.Room.RoomType.UnitPrice * days).Sum()
                         select ValueTuple.Create(rm.Key, value));
            }
            using (var dao = new RoomDAO())
            {
                return from rt in dao.RoomTypes.ToList()
                       join kv in query on rt.Id equals kv.Item1
                       select (rt.Name, kv.Item2);
            }
        }

        public IEnumerable<(string, double)> ServiceRevenueByNameStatistic(int start, int end)
        {
            IEnumerable<(string, double)> query;
            using (var dao = new InvoiceDAO())
            {
                query = from rd in dao.RentRoomDetails.Include(rd => rd.UseServiceDetails).ThenInclude(sd => sd.Service).ToList()
                         where rd.PaidTime != default
                         let k = rd.PaidTime
                         let d = k.Month - 1 + k.Year * 12
                         where d >= start && d <= end
                         from sd in rd.UseServiceDetails
                         group sd by sd.ServiceID into rm
                         let value = (from r in rm select r.Service.UnitPrice * r.Quantity).Sum()
                         select ValueTuple.Create(rm.Key, value);
            }
            using (var dao = new ServiceDAO())
            {
                return from se in dao.Services.ToList()
                       join kv in query on se.Id equals kv.Item1
                       select (se.Name, kv.Item2);
            }
        }
    }
}
