using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoTienda2.Migrations
{
    /// <inheritdoc />
    public partial class si : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "productId");

            migrationBuilder.AddColumn<string>(
                name: "productName",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 1,
                column: "productName",
                value: "note 20");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 2,
                column: "productName",
                value: "s21");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "productId",
                keyValue: 3,
                column: "productName",
                value: "s22");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productName",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "products",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "note 20");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "s21");

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "s22");
        }
    }
}
