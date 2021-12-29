using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.DataAccess.Migrations
{
    public partial class ChangeProvince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_CountryOrRegions_CountryOrRegionCode",
                table: "Provinces");

            migrationBuilder.RenameColumn(
                name: "CountryOrRegionCode",
                table: "Provinces",
                newName: "CountryOrRegionId");

            migrationBuilder.RenameIndex(
                name: "IX_Provinces_CountryOrRegionCode",
                table: "Provinces",
                newName: "IX_Provinces_CountryOrRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_CountryOrRegions_CountryOrRegionId",
                table: "Provinces",
                column: "CountryOrRegionId",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_CountryOrRegions_CountryOrRegionId",
                table: "Provinces");

            migrationBuilder.RenameColumn(
                name: "CountryOrRegionId",
                table: "Provinces",
                newName: "CountryOrRegionCode");

            migrationBuilder.RenameIndex(
                name: "IX_Provinces_CountryOrRegionId",
                table: "Provinces",
                newName: "IX_Provinces_CountryOrRegionCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_CountryOrRegions_CountryOrRegionCode",
                table: "Provinces",
                column: "CountryOrRegionCode",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
