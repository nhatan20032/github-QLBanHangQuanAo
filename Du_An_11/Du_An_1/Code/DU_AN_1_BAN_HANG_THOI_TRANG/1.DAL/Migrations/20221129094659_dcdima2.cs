using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class dcdima2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IdHDCT",
                table: "HoaDonChiTiet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.AddColumn<Guid>(
                name: "IdHDCT",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                column: "IdHDCT");
        }
    }
}
