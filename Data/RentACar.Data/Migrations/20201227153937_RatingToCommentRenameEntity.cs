using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Data.Migrations
{
    public partial class RatingToCommentRenameEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Vehicles_VehicleId",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "StarRating",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Ratings",
                newName: "VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_VehicleId",
                table: "Ratings",
                newName: "IX_Ratings_VehicleID");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Vehicles_VehicleID",
                table: "Ratings",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Vehicles_VehicleID",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "VehicleID",
                table: "Ratings",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_VehicleID",
                table: "Ratings",
                newName: "IX_Ratings_VehicleId");

            migrationBuilder.AddColumn<int>(
                name: "StarRating",
                table: "Ratings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Vehicles_VehicleId",
                table: "Ratings",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
