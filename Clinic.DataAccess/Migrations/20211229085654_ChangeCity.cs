using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.DataAccess.Migrations
{
    public partial class ChangeCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CountryOrRegions_CountryOrRegionCode",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "CountryOrRegionCode",
                table: "Cities",
                newName: "CountryOrRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryOrRegionCode",
                table: "Cities",
                newName: "IX_Cities_CountryOrRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CountryOrRegions_CountryOrRegionId",
                table: "Cities",
                column: "CountryOrRegionId",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_CountryOrRegions_CountryOrRegionId",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "CountryOrRegionId",
                table: "Cities",
                newName: "CountryOrRegionCode");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryOrRegionId",
                table: "Cities",
                newName: "IX_Cities_CountryOrRegionCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_CountryOrRegions_CountryOrRegionCode",
                table: "Cities",
                column: "CountryOrRegionCode",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
