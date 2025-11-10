using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelRezervacniSystem.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Reservation> Reservations => Set<Reservation>();
        public DbSet<Room> Rooms => Set<Room>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
