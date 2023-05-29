using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaMiaPizzeria.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizze_PizzaCategory_PizzaCategoryId",
                table: "Pizze");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaCategory",
                table: "PizzaCategory");

            migrationBuilder.RenameTable(
                name: "PizzaCategory",
                newName: "PizzaCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaCategories",
                table: "PizzaCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizze_PizzaCategories_PizzaCategoryId",
                table: "Pizze",
                column: "PizzaCategoryId",
                principalTable: "PizzaCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizze_PizzaCategories_PizzaCategoryId",
                table: "Pizze");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaCategories",
                table: "PizzaCategories");

            migrationBuilder.RenameTable(
                name: "PizzaCategories",
                newName: "PizzaCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaCategory",
                table: "PizzaCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizze_PizzaCategory_PizzaCategoryId",
                table: "Pizze",
                column: "PizzaCategoryId",
                principalTable: "PizzaCategory",
                principalColumn: "Id");
        }
    }
}
