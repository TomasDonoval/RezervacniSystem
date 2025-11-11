using HotelRezervacniSystem.Models;

namespace HotelRezervacniSystem.Services
{
    public class ReservationService
    {
        private readonly AppDbContext _db;
        public ReservationService(AppDbContext db)
        {
            _db = db;
        }
        public bool IsValidReservationDates(DateTime checkIn, DateTime checkOut)
        {

            return checkOut > checkIn;
        }
        public int FindAvailableRoomNumber(int beds, DateTime checkIn, DateTime checkOut)
        {
            List<Room> rooms = new List<Room>();
            foreach (var room in _db.Rooms)
            {
                if (room.Beds == beds)
                {
                    rooms.Add(room);
                }
            }

            foreach (var room in rooms)
            {
                if (IsRoomAvailable(room.Number, checkIn, checkOut))
                {
                    return room.Number;
                }
            }

            return -1;
        }
        public bool IsRoomAvailable(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            List<Reservation> overlappingReservations = new List<Reservation>();
            foreach (var res in _db.Reservations)
            {
                bool sameRoom = res.RoomNumber == roomNumber;
                bool checkInOverlap = checkIn < res.CheckOutDate;
                bool checkOutOverlap = checkOut > res.CheckInDate;
                if (sameRoom && checkInOverlap && checkOutOverlap)
                {
                    overlappingReservations.Add(res);
                }
            }
            if (overlappingReservations.Count == 0)
            {
                return true;
            }
            return false;
        }
        public bool IsDateInPast(DateTime date)
        {
            return date.Date < DateTime.Now.Date;
        }
    }
}
