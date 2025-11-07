using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelRezervacniSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddBedsToReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Beds",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beds",
                table: "Reservations");
        }
    }
}
