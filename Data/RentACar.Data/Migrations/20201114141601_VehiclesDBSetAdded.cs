using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Data.Migrations
{
    public partial class VehiclesDBSetAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Vehicle_VehicleID",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Vehicle_VehicleId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Vehicle_VehicleID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Vehicle_VehicleId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Facilities_FacilityId",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_IsDeleted",
                table: "Vehicles",
                newName: "IX_Vehicles_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_FacilityId",
                table: "Vehicles",
                newName: "IX_Vehicles_FacilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Vehicles_VehicleID",
                table: "Offers",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Vehicles_VehicleId",
                table: "Pictures",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Vehicles_VehicleID",
                table: "Purchases",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Vehicles_VehicleId",
                table: "Ratings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Facilities_FacilityId",
                table: "Vehicles",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Vehicles_VehicleID",
                table: "Offers");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Vehicles_VehicleId",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Vehicles_VehicleID",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Vehicles_VehicleId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Facilities_FacilityId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_IsDeleted",
                table: "Vehicle",
                newName: "IX_Vehicle_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_FacilityId",
                table: "Vehicle",
                newName: "IX_Vehicle_FacilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Vehicle_VehicleID",
                table: "Offers",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Vehicle_VehicleId",
                table: "Pictures",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Vehicle_VehicleID",
                table: "Purchases",
                column: "VehicleID",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Vehicle_VehicleId",
                table: "Ratings",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Facilities_FacilityId",
                table: "Vehicle",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
