using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuWithEnum.Migrations
{
    /// <inheritdoc />
    public partial class Mg7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "MenuItems");
        }
    }
}
