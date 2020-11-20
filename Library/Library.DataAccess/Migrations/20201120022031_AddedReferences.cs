using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DataAccess.Migrations
{
    public partial class AddedReferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Reservations_ReservationResId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReservationResId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ResId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReservationResId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_BookId",
                table: "Reservations",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Books_BookId",
                table: "Reservations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Books_BookId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_BookId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ResId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservationResId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_ReservationResId",
                table: "Books",
                column: "ReservationResId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Reservations_ReservationResId",
                table: "Books",
                column: "ReservationResId",
                principalTable: "Reservations",
                principalColumn: "ResId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
