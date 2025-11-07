using System.Diagnostics;
using HotelRezervacniSystem.Models;
using Microsoft.AspNetCore.Mvc;
using RezervacniSystem.Models;
using HotelRezervacniSystem.Services;
using Microsoft.VisualBasic;

namespace RezervacniSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;
        private readonly ReservationService reservationService;

        public HomeController(ILogger<HomeController> logger, AppDbContext db, ReservationService reservationService)
        {
            _logger = logger;
            _db = db;
            this.reservationService = reservationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pokoje()
        {
            return View();
        }

        public IActionResult Aktivity()
        {
            return View();
        }
        public IActionResult Wellness()
        {
            return View();
        }
        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Rezervace()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SeznamRezervaci()
        {
            var rezervace = _db.Reservations.ToList();
            return View(rezervace);
        }

        [HttpPost]
        public IActionResult Rezervace(Reservation reservation)
        {

            if (!ModelState.IsValid)
            {
                return View(reservation);
            }
            if (reservationService.IsDateInPast(reservation.CheckInDate))
            {
                ModelState.AddModelError("", "Datum pøíjezdu nemùže být v minulosti.");
                return View(reservation);
            }
            if (!reservationService.IsValidReservationDates(reservation.CheckInDate, reservation.CheckOutDate))
            {
                ModelState.AddModelError("", "Datum odjezdu musí být pozdìji než datum pøíjezdu.");
                return View(reservation);
            }

            int roomNumber = reservationService.FindAvailableRoomNumber(reservation.Beds, reservation.CheckInDate, reservation.CheckOutDate);
            if (roomNumber == -1)
            {
                ModelState.AddModelError("", "Omlouváme se, ale pro zadané datum a typ pokoje není k dispozici žádný volný pokoj.");
                return View(reservation);
            }
            reservation.RoomNumber = roomNumber;

            _db.Reservations.Add(reservation);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult DeleteReservation(int id)
        {
            Reservation? reservationToDelete = _db.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservationToDelete == null)
            {
                return RedirectToAction("SeznamRezervaci");
            }
            _db.Reservations.Remove(reservationToDelete);
            _db.SaveChanges();
            return RedirectToAction("SeznamRezervaci");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
