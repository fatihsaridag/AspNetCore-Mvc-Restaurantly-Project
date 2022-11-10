using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantly.Data.Migrations
{
    public partial class mig_change_reservation_phone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Reservations",
                newName: "Phone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Reservations",
                newName: "Picture");
        }
    }
}
