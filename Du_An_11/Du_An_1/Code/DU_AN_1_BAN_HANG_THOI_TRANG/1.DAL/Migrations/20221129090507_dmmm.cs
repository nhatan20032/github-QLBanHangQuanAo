using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class dmmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Poin",
                table: "KhachHang",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnhMoTa",
                table: "ChiTietSP",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "ChiTietSP",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "Poin",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "AnhMoTa",
                table: "ChiTietSP");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "ChiTietSP");
        }
    }
}
