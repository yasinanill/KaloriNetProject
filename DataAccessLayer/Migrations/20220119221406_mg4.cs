using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mg4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipess",
                columns: table => new
                {
                    RecipesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesStatus = table.Column<bool>(type: "bit", nullable: false),
                    RecipesCalorie = table.Column<double>(type: "float", nullable: false),
                    Recipescarbo = table.Column<double>(type: "float", nullable: false),
                    RecipesProtein = table.Column<double>(type: "float", nullable: false),
                    RecipesFat = table.Column<double>(type: "float", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foodamount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesCook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesMethod1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesMethod2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesMethod3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipess", x => x.RecipesID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipess");
        }
    }
}
