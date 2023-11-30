using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Data.Transfer;
using HotelManagement.Data.Transfer.Ultils;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace HotelManagement.Business
{
    public class ReservationBUS
    {
        private ReservationDAO reservationDAO = new ReservationDAO();
        
        public List<Reservation> getAll()
        {
            return reservationDAO.Reservations
                .Include(r => r.Staff)
                .Include(r => r.Customer)
                .AsNoTracking()
                .ToList();
        }

        public int getLengthReservationByCustomerId(string customerId)
        {
            return reservationDAO.Reservations.Where(item => item.CustomerID.Equals(customerId)).Count();
        }

        public Reservation getById(string id)
        {
            return getAll().Find(item => item.Id.Equals(id));
        }
        public int add(Reservation reservation)
        {
            reservationDAO.Entry(reservation).State = EntityState.Detached;
            reservationDAO.Reservations.Attach(reservation);
            reservationDAO.Entry(reservation).State = EntityState.Added;
            // Save changes to the database
            return reservationDAO.SaveChanges();
        }

        public int update(Reservation reservation)
        {
            reservationDAO.Entry(reservation).State = EntityState.Detached;
            reservationDAO.Reservations.Attach(reservation);
            reservationDAO.Entry(reservation).State = EntityState.Modified;

            Reservation temp = reservationDAO.Reservations.First(item => item.Id.Equals(reservation.Id));
            temp.StaffID = reservation.StaffID;
            temp.CustomerID = reservation.CustomerID;
            temp.CreatedAt = reservation.CreatedAt;

            return reservationDAO.SaveChanges();
        }

        public int delete(string id)
        {
            Reservation temp = reservationDAO.Reservations.First(item => item.Id.Equals(id));
            reservationDAO.Reservations.Remove(temp);
            return reservationDAO.SaveChanges();
        }
        public int getLength()
        {
            return reservationDAO.Reservations.Count();
        }

        public bool checkReservationId(string id)
        {
            return getAll().Any(item =>  item.Id.Equals(id));
        }
    }

    public class RoomReservationBUS
    {
        private ReservationDAO reservationDAO = new ReservationDAO();
        private RoomBUS roomBUS = new RoomBUS();

        public List<RoomReservation> getAllRoomReservation()
        {
            return reservationDAO.RoomReservations
                .Include(r => r.Room)
                .Include(r => r.Room.RoomType)
                .Include(r => r.Reservation)
                .Include(r => r.Reservation.Customer)
                .AsNoTracking().ToList();
        }

        public List<RoomReservation> getAllRoomReservationByReservationId(string reservationID)
        {
            return getAllRoomReservation()
                .Where(item => item.ReservationID.Equals(reservationID))
                .ToList();
        }

        public void loadOutDateAllRoomReservation()
        {
            reservationDAO.RoomReservations.ToList().ForEach(item =>
            {
                if(item.Status == RoomReservationStatus.Booked && Functions.getDayGap(item.EndTime, DateTime.Now) > 0)
                {
                    item.Status = RoomReservationStatus.OutDate;
                }
            });
            reservationDAO.SaveChanges();
        }

        public int addRoomReservation(RoomReservation roomReservation)
        {
            reservationDAO.Entry(roomReservation).State = EntityState.Detached;
            reservationDAO.RoomReservations.Attach(roomReservation);
            reservationDAO.Entry(roomReservation).State = EntityState.Added;
            reservationDAO.RoomReservations.Add(roomReservation);
            reservationDAO.ChangeTracker.DetectChanges();
            return reservationDAO.SaveChanges();
        }

        public int updateRoomReservation(RoomReservation roomReservation)
        {
            RoomReservation temp = reservationDAO.RoomReservations.First(item => item.RoomID.Equals(roomReservation.RoomID) && item.ReservationID.Equals(roomReservation.ReservationID));
            temp.StartTime = roomReservation.StartTime;
            temp.EndTime = roomReservation.EndTime;
            temp.Status = roomReservation.Status;
            return reservationDAO.SaveChanges();
        }

        public int deleteRoomReservation(string roomId, string reservationId)
        {
            var temp = reservationDAO.RoomReservations.First(item => item.RoomID.Equals(roomId) && item.ReservationID.Equals(reservationId));
            reservationDAO.RoomReservations.Remove(temp);
            return reservationDAO.SaveChanges();
        }

        public int getLengthRoomReservationByReservationId(string reservationId)
        {
            return reservationDAO.RoomReservations
                .Where(item => item.ReservationID.Equals(reservationId))
                .Count();
        }

        public List<RoomReservation> getListRoomReservationBookedAndRentedHistory(DateTime date)
        {
            return getAllRoomReservation()
                .Where(item =>
                {
                    bool checkInRange = (Functions.getDayGap(item.StartTime, date) >= 0 && Functions.getDayGap(date, item.EndTime) >= 0);
                    bool checkStatus = item.Status == RoomReservationStatus.Booked || item.Status == RoomReservationStatus.Rented;
                    return checkStatus && checkInRange;
                })
                .ToList();
        }

        public List<RoomReservation> getListBookedAndRentedRoom(DateTime from, DateTime to)
        {
            return getAllRoomReservation()
                .Where(item =>
                {
                    bool checkInRange = (Functions.getDayGap(from, item.StartTime) >= 0 && Functions.getDayGap(item.StartTime, to) >= 0) ||
                    (Functions.getDayGap(from, item.EndTime) >= 0 && Functions.getDayGap(item.EndTime, to) >= 0);
                    bool checkStatus = item.Status == RoomReservationStatus.Booked || item.Status == RoomReservationStatus.Rented;
                    return checkStatus && checkInRange;
                })
                .ToList();  
        }

        public List<RoomReservation> getListBookedAndRentedRoomWithReservationID(DateTime from, DateTime to, string reservationId)
        {
            return getAllRoomReservation()
                .Where(item =>
                {
                    bool checkInRange = (Functions.getDayGap(from, item.StartTime) >= 0 && Functions.getDayGap(item.StartTime, to) >= 0) ||
                    (Functions.getDayGap(from, item.EndTime) >= 0 && Functions.getDayGap(item.EndTime, to) >= 0);
                    bool checkStatus = item.Status == RoomReservationStatus.Booked || item.Status == RoomReservationStatus.Rented;
                    return checkStatus && checkInRange && !item.ReservationID.Equals(reservationId);
                })
                .ToList();
        }

        public List<Room> getListRoomAllowBooking(DateTime from, DateTime to)
        {
            //Danh sach cac phong da duoc dat
            List<RoomReservation> listBookedRoom = getListBookedAndRentedRoom(from, to);

            //Danh sach cac phong co the dat
            List<Room> listCleanedRoom = roomBUS.getAllCleanedRoom();

            //Danh sach phong Co the dat va chua duoc dat
            List<Room> listRoomAllowBooking = listCleanedRoom
                .Where(item => !listBookedRoom.Any(book => book.RoomID.Equals(item.Id))).ToList();

            return listRoomAllowBooking;
        }

        public List<Room> getListRoomAllowBookingWithReservationId(DateTime from, DateTime to, string reservationId)
        {
            //Danh sach cac phong da duoc dat
            List<RoomReservation> listBookedRoom = getListBookedAndRentedRoomWithReservationID(from, to, reservationId);

            //Danh sach cac phong co the dat
            List<Room> listCleanedRoom = roomBUS.getAllCleanedRoom();

            //Danh sach phong Co the dat va chua duoc dat
            List<Room> listRoomAllowBooking = listCleanedRoom
                .Where(item => !listBookedRoom.Any(book => book.RoomID.Equals(item.Id)))
                .ToList();

            return listRoomAllowBooking;
        }

        public int deleteAllBookedRoomInReservation(string reservationId)
        {
            var reservationsToRemove = reservationDAO.RoomReservations
            .Where(item => item.ReservationID.Equals(reservationId))
            .ToList();

            reservationDAO.RoomReservations.RemoveRange(reservationsToRemove);
            
            return reservationDAO.SaveChanges();
        }

        public int addAllBookedRoomInReservation(List<RoomReservation> list)
        {
            reservationDAO.RoomReservations.AddRange(list);
            return reservationDAO.SaveChanges();
        }
    }
}
