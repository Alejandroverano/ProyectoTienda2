using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoTienda2.Migrations
{
    /// <inheritdoc />
    public partial class tienda1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "iphones",
                columns: new[] { "Idiphone", "Nameiphone", "unitpriceiphone" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 1,
                columns: new[] { "productName", "unitprice" },
                values: new object[] { "Samsung Galaxy S23", 959.0 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 2,
                columns: new[] { "productName", "unitprice" },
                values: new object[] { "Samsung Galaxy S23+", 1209.0 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 3,
                columns: new[] { "productName", "unitprice" },
                values: new object[] { "Samsung Galaxy S23 Ultra", 1409.0 });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "productId", "productName", "unitprice" },
                values: new object[,]
                {
                    { 4, "Samsung Galaxy A54 5G ", 499.0 },
                    { 5, "Samsung Galaxy A34 5G", 469.0 },
                    { 6, "Samsung Galaxy A53 5G", 335.0 },
                    { 7, "Samsung Galaxy A13", 179.0 },
                    { 8, "Samsung Galaxy A14", 185.0 },
                    { 9, "Samsung Galaxy A04 Core", 170.0 },
                    { 10, "Samsung Galaxy A10s", 100.0 }
                });

            migrationBuilder.UpdateData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 1,
                columns: new[] { "Namerealme", "unitpricerealme" },
                values: new object[] { "Realme GT 2 Pro", 699.99000000000001 });

            migrationBuilder.InsertData(
                table: "realmes",
                columns: new[] { "Idrealme", "Namerealme", "unitpricerealme" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 1,
                columns: new[] { "Namexiaomi", "unitpricexiaomi" },
                values: new object[] { "Xiaomi 13", 650.0 });

            migrationBuilder.InsertData(
                table: "xiaomis",
                columns: new[] { "Idxiaomi", "Namexiaomi", "unitpricexiaomi" },
                values: new object[,]
                {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "iphones",
                keyColumn: "Idiphone",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "productId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 1,
                columns: new[] { "productName", "unitprice" },
                values: new object[] { "note 20", 9.9900000000000002 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 2,
                columns: new[] { "productName", "unitprice" },
                values: new object[] { "s21", 999.0 });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 3,
                columns: new[] { "productName", "unitprice" },
                values: new object[] { "s22", 5555.0 });

            migrationBuilder.UpdateData(
                table: "realmes",
                keyColumn: "Idrealme",
                keyValue: 1,
                columns: new[] { "Namerealme", "unitpricerealme" },
                values: new object[] { "Realme gt", 599.99000000000001 });

            migrationBuilder.UpdateData(
                table: "xiaomis",
                keyColumn: "Idxiaomi",
                keyValue: 1,
                columns: new[] { "Namexiaomi", "unitpricexiaomi" },
                values: new object[] { "Marcela Padilla", 9.9900000000000002 });
        }
    }
}
