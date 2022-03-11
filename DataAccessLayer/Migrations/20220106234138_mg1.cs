using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    ExpertID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodStatus = table.Column<bool>(type: "bit", nullable: false),
                    ExpertPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertSocial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertSocial2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertSocial3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertMenu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertBlog = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.ExpertID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserWeight = table.Column<double>(type: "float", nullable: false),
                    UserHeight = table.Column<double>(type: "float", nullable: false),
                    UserDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserStatus = table.Column<bool>(type: "bit", nullable: false),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Profils",
                columns: table => new
                {
                    ProfilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Saat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profils", x => x.ProfilID);
                    table.ForeignKey(
                        name: "FK_Profils_Users_UserID1",
                        column: x => x.UserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Foodss",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodStatus = table.Column<bool>(type: "bit", nullable: false),
                    FoodCalorie = table.Column<double>(type: "float", nullable: false),
                    Foodcarbo = table.Column<double>(type: "float", nullable: false),
                    FoodProtein = table.Column<double>(type: "float", nullable: false),
                    FoodFat = table.Column<double>(type: "float", nullable: false),
                    Foodamount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foodss", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foodss_Profils_ProfilID",
                        column: x => x.ProfilID,
                        principalTable: "Profils",
                        principalColumn: "ProfilID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foodss_ProfilID",
                table: "Foodss",
                column: "ProfilID");

            migrationBuilder.CreateIndex(
                name: "IX_Profils_UserID1",
                table: "Profils",
                column: "UserID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Foodss");

            migrationBuilder.DropTable(
                name: "Profils");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
