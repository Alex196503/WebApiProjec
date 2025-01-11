using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProjec.Migrations
{
    /// <inheritdoc />
    public partial class asdgsdsgdgh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Review_Trainer_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Trainer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_TrainerID",
                table: "Member",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_TrainerID",
                table: "Review",
                column: "TrainerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Trainer_TrainerID",
                table: "Member",
                column: "TrainerID",
                principalTable: "Trainer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Trainer_TrainerID",
                table: "Member");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropIndex(
                name: "IX_Member_TrainerID",
                table: "Member");
        }
    }
}
