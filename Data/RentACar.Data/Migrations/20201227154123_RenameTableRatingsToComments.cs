using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.Data.Migrations
{
    public partial class RenameTableRatingsToComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_AspNetUsers_UserID",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Vehicles_VehicleID",
                table: "Ratings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings");

            migrationBuilder.RenameTable(
                name: "Ratings",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_VehicleID",
                table: "Comments",
                newName: "IX_Comments_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_UserID",
                table: "Comments",
                newName: "IX_Comments_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_IsDeleted",
                table: "Comments",
                newName: "IX_Comments_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserID",
                table: "Comments",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Vehicles_VehicleID",
                table: "Comments",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Vehicles_VehicleID",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Ratings");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_VehicleID",
                table: "Ratings",
                newName: "IX_Ratings_VehicleID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserID",
                table: "Ratings",
                newName: "IX_Ratings_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_IsDeleted",
                table: "Ratings",
                newName: "IX_Ratings_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ratings",
                table: "Ratings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_AspNetUsers_UserID",
                table: "Ratings",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Vehicles_VehicleID",
                table: "Ratings",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
