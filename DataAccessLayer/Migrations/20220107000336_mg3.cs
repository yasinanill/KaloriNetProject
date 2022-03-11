using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foodss_Profils_ProfilID",
                table: "Foodss");

            migrationBuilder.DropForeignKey(
                name: "FK_Profils_Users_UserID1",
                table: "Profils");

            migrationBuilder.DropIndex(
                name: "IX_Profils_UserID1",
                table: "Profils");

            migrationBuilder.DropIndex(
                name: "IX_Foodss_ProfilID",
                table: "Foodss");

            migrationBuilder.DropColumn(
                name: "ProfilID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Profils");

            migrationBuilder.DropColumn(
                name: "ProfilID",
                table: "Foodss");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfilID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "Profils",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfilID",
                table: "Foodss",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profils_UserID1",
                table: "Profils",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Foodss_ProfilID",
                table: "Foodss",
                column: "ProfilID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foodss_Profils_ProfilID",
                table: "Foodss",
                column: "ProfilID",
                principalTable: "Profils",
                principalColumn: "ProfilID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Profils_Users_UserID1",
                table: "Profils",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
