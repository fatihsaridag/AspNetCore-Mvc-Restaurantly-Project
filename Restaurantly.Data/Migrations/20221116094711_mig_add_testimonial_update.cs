using Microsoft.EntityFrameworkCore.Migrations;

namespace Restaurantly.Data.Migrations
{
    public partial class mig_add_testimonial_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Testimonials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "Testimonials",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "Testimonials");
        }
    }
}
