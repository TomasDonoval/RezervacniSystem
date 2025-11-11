using HotelRezervacniSystem.Models;
using HotelRezervacniSystem.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// ? SQLite dev + production
var connectionString = builder.Environment.IsProduction()
    ? "Data Source=/data/app.db"
    : "Data Source=app.db";

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddScoped<ReservationService>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromDays(30);
    options.SlidingExpiration = true;
    options.Cookie.Name = "HotelAurelia.Auth";
});

var app = builder.Build();

// ? Migrace + seed
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();

    if (!db.Rooms.Any())
    {
        db.Rooms.AddRange(
            new Room { Number = 101, Beds = 2 },
            new Room { Number = 102, Beds = 2 },
            new Room { Number = 103, Beds = 4 },
            new Room { Number = 201, Beds = 2 },
            new Room { Number = 202, Beds = 4 },
            new Room { Number = 203, Beds = 4 }
        );
        db.SaveChanges();
    }
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
