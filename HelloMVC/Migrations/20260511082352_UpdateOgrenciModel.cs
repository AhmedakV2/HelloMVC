using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelloMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOgrenciModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ogrenciler",
                newName: "OgrenciId");

            migrationBuilder.AddColumn<int>(
                name: "Numara",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numara",
                table: "Ogrenciler");

            migrationBuilder.RenameColumn(
                name: "OgrenciId",
                table: "Ogrenciler",
                newName: "Id");
        }
    }
}
