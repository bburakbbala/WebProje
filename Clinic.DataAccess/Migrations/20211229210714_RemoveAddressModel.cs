using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.DataAccess.Migrations
{
    public partial class RemoveAddressModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Addresses_AddressId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Addresses_AddressId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Addresses_AddressId",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Patients",
                newName: "ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_AddressId",
                table: "Patients",
                newName: "IX_Patients_ProvinceId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Labs",
                newName: "ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Labs_AddressId",
                table: "Labs",
                newName: "IX_Labs_ProvinceId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Hospitals",
                newName: "ProvinceId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospitals_AddressId",
                table: "Hospitals",
                newName: "IX_Hospitals_ProvinceId");

            migrationBuilder.AddColumn<string>(
                name: "AddressDetail",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryOrRegionId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressDetail",
                table: "Labs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Labs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryOrRegionId",
                table: "Labs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressDetail",
                table: "Hospitals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Hospitals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryOrRegionId",
                table: "Hospitals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CityId",
                table: "Patients",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_CountryOrRegionId",
                table: "Patients",
                column: "CountryOrRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_CityId",
                table: "Labs",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_CountryOrRegionId",
                table: "Labs",
                column: "CountryOrRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_CityId",
                table: "Hospitals",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_CountryOrRegionId",
                table: "Hospitals",
                column: "CountryOrRegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_CountryOrRegions_CountryOrRegionId",
                table: "Hospitals",
                column: "CountryOrRegionId",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Provinces_CityId",
                table: "Hospitals",
                column: "CityId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Provinces_ProvinceId",
                table: "Hospitals",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_CountryOrRegions_CountryOrRegionId",
                table: "Labs",
                column: "CountryOrRegionId",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Provinces_CityId",
                table: "Labs",
                column: "CityId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Provinces_ProvinceId",
                table: "Labs",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_CountryOrRegions_CountryOrRegionId",
                table: "Patients",
                column: "CountryOrRegionId",
                principalTable: "CountryOrRegions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provinces_CityId",
                table: "Patients",
                column: "CityId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Provinces_ProvinceId",
                table: "Patients",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_CountryOrRegions_CountryOrRegionId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Provinces_CityId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Provinces_ProvinceId",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_CountryOrRegions_CountryOrRegionId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Provinces_CityId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Provinces_ProvinceId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_CountryOrRegions_CountryOrRegionId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provinces_CityId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Provinces_ProvinceId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_CityId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_CountryOrRegionId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Labs_CityId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_Labs_CountryOrRegionId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_CityId",
                table: "Hospitals");

            migrationBuilder.DropIndex(
                name: "IX_Hospitals_CountryOrRegionId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "AddressDetail",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "CountryOrRegionId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AddressDetail",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "CountryOrRegionId",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "AddressDetail",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "CountryOrRegionId",
                table: "Hospitals");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Patients",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ProvinceId",
                table: "Patients",
                newName: "IX_Patients_AddressId");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Labs",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Labs_ProvinceId",
                table: "Labs",
                newName: "IX_Labs_AddressId");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Hospitals",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospitals_ProvinceId",
                table: "Hospitals",
                newName: "IX_Hospitals_AddressId");

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    CountryOrRegionId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_CountryOrRegions_CountryOrRegionId",
                        column: x => x.CountryOrRegionId,
                        principalTable: "CountryOrRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Provinces_CityId",
                        column: x => x.CityId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryOrRegionId",
                table: "Addresses",
                column: "CountryOrRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceId",
                table: "Addresses",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Addresses_AddressId",
                table: "Hospitals",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Addresses_AddressId",
                table: "Labs",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Addresses_AddressId",
                table: "Patients",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
