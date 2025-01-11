using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProjec.Migrations
{
    /// <inheritdoc />
    public partial class asfasg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Court",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Court", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    CourtID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reservation_Court_CourtID",
                        column: x => x.CourtID,
                        principalTable: "Court",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CourtID",
                table: "Reservation",
                column: "CourtID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_MemberID",
                table: "Reservation",
                column: "MemberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Court");
        }
    }
}
