using System.ComponentModel.DataAnnotations;

namespace HotelRezervacniSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Jméno hosta je povinné")]
        public string GuestName { get; set; } = "";
        [Required(ErrorMessage = "Datum příjezdu je povinné")]
        public DateTime CheckInDate { get; set; }
        [Required(ErrorMessage = "Datum odjezdu je povinné")]
        public DateTime CheckOutDate { get; set; }

        [Required(ErrorMessage = "Vyberte typ pokoje")]
        public int Beds { get; set; }
        public int RoomNumber { get; set; }
    }
}
