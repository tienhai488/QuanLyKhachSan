using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Data.Transfer;
using HotelManagement.Data.Transfer.Ultils;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelManagement.Business
{
    public class ReservationBUS
    {
        private ReservationDAO reservationDAO = new ReservationDAO();
        
        public List<Reservation> getAll()
        {
            return reservationDAO.Reservations
                //.Include(r => r.Staff)
                .Include(r => r.Customer)
                .AsNoTracking()
                .ToList();
        }

        public Reservation getById(string id)
        {
            return reservationDAO.Reservations.AsNoTracking().First(item => item.Id.Equals(id));
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

        public Staff getStaffById(string id)
        {
            using (StaffDAO staffDAO = new StaffDAO())
            {
                staffDAO.Set<Staff>().ToList().Find(item => item.Id == 1);
            }
            return reservationDAO.Set<Staff>().ToList().Find(item => item.Id == 1);
        }
    }

    public class RoomReservationBUS
    {
        private ReservationDAO reservationDAO = new ReservationDAO();
        private RoomBUS roomBUS = new RoomBUS();

        public List<RoomReservation> getAllRoomReservation()
        {
            return reservationDAO.RoomReservations.AsNoTracking().ToList();
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

        public int getLengthRoomReservation()
        {
            return reservationDAO.RoomReservations.Count();
        }

        public List<RoomReservation> getListBookedRoom(DateTime from)
        {
            return getAllRoomReservation()
                .Where(item => item.Status == 0 && Functions.getDayGap(from, item.EndTime) >= 0).ToList();
        }

        public List<Room> getListRoomAllowBooking(DateTime from)
        {
            //Danh sach cac phong da duoc dat
            List<RoomReservation> listBookedRoom = getListBookedRoom(from);

            //Danh sach cac phong co the dat
            List<Room> listCleanedRoom = roomBUS.getAllCleanedRoom();

            //Danh sach phong Co the dat va chua duoc dat
            List<Room> listRoomAllowBooking = listCleanedRoom
                .Where(item => !listBookedRoom.Any(book => book.RoomID.Equals(item.Id))).ToList();

            return listRoomAllowBooking;
        }

        public int deleteAllBookedRoomInReservation(string reservationId)
        {
            List<RoomReservation> list = getAllRoomReservation().Where(item => item.ReservationID.Equals(reservationId)).ToList();
            reservationDAO.RoomReservations.RemoveRange(list);
            return reservationDAO.SaveChanges();
        }

        public int addAllBookedRoomInReservation(List<RoomReservation> list)
        {
            reservationDAO.RoomReservations.AddRange(list);
            return reservationDAO.SaveChanges();
        }
    }
}
