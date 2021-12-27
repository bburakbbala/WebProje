using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.DataAccess.Migrations
{
    public partial class AddDescriptionToHospitalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Hospitals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Hospitals");
        }
    }
}
