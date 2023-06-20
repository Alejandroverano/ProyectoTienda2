using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoTienda2.Migrations
{
    /// <inheritdoc />
    public partial class tiedan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iphones");

            migrationBuilder.DropTable(
                name: "realmes");

            migrationBuilder.DropTable(
                name: "xiaomis");

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "productId", "productName", "unitprice" },
                values: new object[,]
                {
                    { 12, "Xiaomi 13", 650.0 },
                    { 13, "Xiaomi 13 pro", 750.0 },
                    { 14, "Xiaomi 12S Ultra", 1200.0 },
                    { 15, "Redmi note 12", 190.0 },
                    { 16, "Redmi note 12 Pro", 270.0 },
                    { 17, "Redmi note 12 Pro plus", 335.0 },
                    { 18, "Redmi 9c", 80.0 },
                    { 19, "Redmi 10C", 92.0 },
                    { 20, "Redmi 11C", 90.0 },
                    { 21, "Redmi 12C", 95.0 },
                    { 22, "iphone 12", 990.0 },
                    { 23, "iphone 12 Pro", 1100.0 },
                    { 24, "iphone 12 Pro Max", 1200.0 },
                    { 25, "iphone 13", 900.0 },
                    { 26, "iphone 13 Pro ", 1100.0 },
                    { 27, "iphone 13 Pro Max", 1200.0 },
                    { 28, "iphone 14", 900.0 },
                    { 29, "iphone 14 Pro", 1100.0 },
                    { 30, "iphone 14 Plus", 1150.0 },
                    { 31, "iphone 14 Pro Max", 1200.0 },
                    { 32, "Realme Gt 2 Pro", 690.0 },
                    { 33, "Realme GT 2", 500.0 },
                    { 34, "Samsung Galaxy A10s", 100.0 },
                    { 35, "Realme GT ", 450.0 },
                    { 36, "Realme 9 Pro plus", 350.0 },
                    { 37, "Realme GT Master Edition", 340.0 },
                    { 38, "Realme 9 Pro", 330.0 },
                    { 39, "Realme C35", 199.0 },
                    { 40, "Realme C25Y", 179.0 },
                    { 41, "Realme C31", 159.0 },
                    { 42, "Realme C21Y", 130.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 42);

            migrationBuilder.CreateTable(
                name: "iphones",
                columns: table => new
                {
                    Idiphone = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nameiphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unitpriceiphone = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_iphones", x => x.Idiphone);
                });

            migrationBuilder.CreateTable(
                name: "realmes",
                columns: table => new
                {
                    Idrealme = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namerealme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unitpricerealme = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_realmes", x => x.Idrealme);
                });

            migrationBuilder.CreateTable(
                name: "xiaomis",
                columns: table => new
                {
                    Idxiaomi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namexiaomi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    unitpricexiaomi = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xiaomis", x => x.Idxiaomi);
                });

            migrationBuilder.InsertData(
                table: "iphones",
                columns: new[] { "Idiphone", "Nameiphone", "unitpriceiphone" },
                values: new object[,]
                {
                    { 1, "iphone 12", 999.99000000000001 },
                    { 2, "iphone 12 Pro", 1099.99 },
                    { 3, "iphone 12 Pro Max", 1199.99 },
                    { 4, "iphone 13", 999.99000000000001 },
                    { 5, "iphone 13 Pro ", 1099.99 },
                    { 6, "iphone 13 Pro Max", 1199.99 },
                    { 7, "iphone 14", 999.99000000000001 },
                    { 8, "iphone 14 Pro", 1099.99 },
                    { 9, "iphone 14 Plus", 1159.99 },
                    { 10, "iphone 14 Pro Max", 1469.99 }
                });

            migrationBuilder.InsertData(
                table: "realmes",
                columns: new[] { "Idrealme", "Namerealme", "unitpricerealme" },
                values: new object[,]
                {
                    { 1, "Realme GT 2 Pro", 699.99000000000001 },
                    { 2, "Realme GT 2", 499.99000000000001 },
                    { 3, "Realme GT", 399.99000000000001 },
                    { 4, "Realme 9 Pro plus", 350.99000000000001 },
                    { 5, "Realme GT Master Edition", 340.99000000000001 },
                    { 6, "Realme 9 Pro", 329.99000000000001 },
                    { 7, "Realme C35", 199.99000000000001 },
                    { 8, "Realme C25Y", 179.99000000000001 },
                    { 9, "Realme C31", 159.99000000000001 },
                    { 10, "Realme C21Y", 139.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "xiaomis",
                columns: new[] { "Idxiaomi", "Namexiaomi", "unitpricexiaomi" },
                values: new object[,]
                {
                    { 1, "Xiaomi 13", 650.0 },
                    { 2, "Xiaomi 13 pro", 750.0 },
                    { 3, "Xiaomi 12S Ultra", 1200.0 },
                    { 4, "Redmi Note 12", 190.99000000000001 },
                    { 5, "Redmi note 12 Pro", 270.0 },
                    { 6, "Redmi note 12 Pro Plus", 335.0 },
                    { 7, "Redmi 9c", 80.0 },
                    { 8, "Redmi 10C", 92.0 },
                    { 9, "Redmi 11c", 90.0 },
                    { 10, "Redmi 12C", 95.0 }
                });
        }
    }
}
