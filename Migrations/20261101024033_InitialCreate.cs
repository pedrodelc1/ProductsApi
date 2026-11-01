using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814

namespace ProductsApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Mouse inalámbrico", 3999.99m },
                    { 2, "Teclado mecánico", 8299.50m },
                    { 3, "Monitor 24 pulgadas", 52499.00m },
                    { 4, "Notebook Dell Inspiron", 185000.00m },
                    { 5, "Auriculares Bluetooth", 10499.90m },
                    { 6, "Webcam HD", 7999.00m },
                    { 7, "Silla ergonómica", 61200.00m },
                    { 8, "Disco SSD 1TB", 44999.99m },
                    { 9, "Tablet Samsung Galaxy", 93499.00m },
                    { 10, "Impresora multifunción", 73900.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
