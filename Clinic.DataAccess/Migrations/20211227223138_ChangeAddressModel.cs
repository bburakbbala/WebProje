using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.DataAccess.Migrations
{
    public partial class ChangeAddressModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Provinces_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Provinces_ProvinceId",
                table: "Addresses",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Provinces_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Provinces_ProvinceId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Addresses");
        }
    }
}
