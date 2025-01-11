using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProjec.Migrations
{
    /// <inheritdoc />
    public partial class ds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Membership",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membership", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Member_MembershipID",
                table: "Member",
                column: "MembershipID");

            migrationBuilder.AddForeignKey(
                name: "FK_Member_Membership_MembershipID",
                table: "Member",
                column: "MembershipID",
                principalTable: "Membership",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Member_Membership_MembershipID",
                table: "Member");

            migrationBuilder.DropTable(
                name: "Membership");

            migrationBuilder.DropIndex(
                name: "IX_Member_MembershipID",
                table: "Member");
        }
    }
}
