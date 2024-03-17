using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBanHangLaptop.Migrations
{
    /// <inheritdoc />
    public partial class AddThumnailColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Thumnail",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumnail",
                table: "Products");
        }
    }
}
