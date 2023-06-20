using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tienda2.Migrations
{
    /// <inheritdoc />
    public partial class ling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logings",
                columns: table => new
                {
                    usuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logings", x => x.usuario);
                });

            migrationBuilder.InsertData(
                table: "logings",
                columns: new[] { "usuario", "contraseña" },
                values: new object[,]
                {
                    { "Alejandro", "Bruno123" },
                    { "Francisco", "HijodeAlejandro" },
                    { "Steven", "Pompi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logings");
        }
    }
}
