using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProyectoTienda2.Migrations
{
    /// <inheritdoc />
    public partial class tienda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unitprice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
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
                values: new object[] { 1, "iphone 12", 999.99000000000001 });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Name", "unitprice" },
                values: new object[,]
                {
                    { 1, "note 20", 9.9900000000000002 },
                    { 2, "s21", 999.0 },
                    { 3, "s22", 5555.0 }
                });

            migrationBuilder.InsertData(
                table: "realmes",
                columns: new[] { "Idrealme", "Namerealme", "unitpricerealme" },
                values: new object[] { 1, "Realme gt", 599.99000000000001 });

            migrationBuilder.InsertData(
                table: "xiaomis",
                columns: new[] { "Idxiaomi", "Namexiaomi", "unitpricexiaomi" },
                values: new object[] { 1, "Marcela Padilla", 9.9900000000000002 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "iphones");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "realmes");

            migrationBuilder.DropTable(
                name: "xiaomis");
        }
    }
}
