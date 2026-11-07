using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QuanLyDocGia.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiDocGias",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDocGias", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    MaDG = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhiThuongNien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaLoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.MaDG);
                    table.ForeignKey(
                        name: "FK_DocGias_LoaiDocGias_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiDocGias",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LoaiDocGias",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { "GV", "Giảng viên" },
                    { "SV", "Sinh viên" }
                });

            migrationBuilder.InsertData(
                table: "DocGias",
                columns: new[] { "MaDG", "GioiTinh", "HoTen", "MaLoai", "NgaySinh", "PhiThuongNien" },
                values: new object[,]
                {
                    { "DG001", false, "Nguyễn Minh Anh", "SV", new DateTime(2001, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000m },
                    { "DG002", true, "Trần Đức Long", "SV", new DateTime(2004, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 120000m },
                    { "DG003", false, "Lê Thu Hà", "GV", new DateTime(1985, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 200000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocGias_MaLoai",
                table: "DocGias",
                column: "MaLoai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocGias");

            migrationBuilder.DropTable(
                name: "LoaiDocGias");
        }
    }
}
