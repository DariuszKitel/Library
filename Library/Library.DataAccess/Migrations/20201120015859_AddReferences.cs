using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.DataAccess.Migrations
{
    public partial class AddReferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResId",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservationResId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ResId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    BookDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ResId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Reservations_ReservationResId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Books_ReservationResId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ResId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReservationResId",
                table: "Books");
        }
    }
}
