using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class dcdima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_HinhThucThanhToan_IDHTTT",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.AddColumn<Guid>(
                name: "IdHDCT",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ID",
                table: "HoaDonChiTiet",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "HoaDon",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IDHTTT",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Ma",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                column: "IdHDCT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDHD",
                table: "HoaDonChiTiet",
                column: "IDHD");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_HinhThucThanhToan_IDHTTT",
                table: "HoaDon",
                column: "IDHTTT",
                principalTable: "HinhThucThanhToan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_HinhThucThanhToan_IDHTTT",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HoaDonChiTiet_IDHD",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "IdHDCT",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "HoaDonChiTiet");

            migrationBuilder.DropColumn(
                name: "Ma",
                table: "HoaDon");

            migrationBuilder.AlterColumn<decimal>(
                name: "ThanhTien",
                table: "HoaDon",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IDHTTT",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonChiTiet",
                table: "HoaDonChiTiet",
                columns: new[] { "IDHD", "IDChiTietSP" });

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_HinhThucThanhToan_IDHTTT",
                table: "HoaDon",
                column: "IDHTTT",
                principalTable: "HinhThucThanhToan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
