using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaMiaPizzeria.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzaCategoryId",
                table: "Pizze",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PizzaCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizze_PizzaCategoryId",
                table: "Pizze",
                column: "PizzaCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizze_PizzaCategory_PizzaCategoryId",
                table: "Pizze",
                column: "PizzaCategoryId",
                principalTable: "PizzaCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizze_PizzaCategory_PizzaCategoryId",
                table: "Pizze");

            migrationBuilder.DropTable(
                name: "PizzaCategory");

            migrationBuilder.DropIndex(
                name: "IX_Pizze_PizzaCategoryId",
                table: "Pizze");

            migrationBuilder.DropColumn(
                name: "PizzaCategoryId",
                table: "Pizze");
        }
    }
}
