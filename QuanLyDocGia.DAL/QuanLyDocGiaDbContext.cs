using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using QuanLyDocGia.Entity;

namespace QuanLyDocGia.DAL
{
    public class QuanLyDocGiaDbContext : DbContext
    {
        public DbSet<LoaiDocGia> LoaiDocGias { get; set; } = null!;
        public DbSet<DocGia> DocGias { get; set; } = null!;

        public QuanLyDocGiaDbContext()
        {
        }

        public QuanLyDocGiaDbContext(DbContextOptions<QuanLyDocGiaDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connStr = ConfigurationManager.ConnectionStrings["QuanLyDocGiaConnection"]?.ConnectionString;
                
                if (string.IsNullOrWhiteSpace(connStr))
                {
                    connStr = @"Server=(localdb)\MSSQLLocalDB;Database=QuanLyDocGiaDB;Trusted_Connection=True;TrustServerCertificate=True;";
                }

                optionsBuilder.UseSqlServer(connStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DocGia>()
                .HasOne(d => d.LoaiDocGia)
                .WithMany(l => l.DocGias)
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LoaiDocGia>().HasData(
                new LoaiDocGia { MaLoai = "SV", TenLoai = "Sinh viên" },
                new LoaiDocGia { MaLoai = "GV", TenLoai = "Giảng viên" }
            );

            modelBuilder.Entity<DocGia>().HasData(
                new DocGia
                {
                    MaDG = "DG001",
                    HoTen = "Nguyễn Đăng Khoa",
                    GioiTinh = true,
                    NgaySinh = new DateTime(2005, 4, 15),
                    PhiThuongNien = 120000m,
                    MaLoai = "SV"
                },
                new DocGia
                {
                    MaDG = "DG002",
                    HoTen = "Phan Thu An",
                    GioiTinh = false,
                    NgaySinh = new DateTime(2006, 8, 29),
                    PhiThuongNien = 120000m,
                    MaLoai = "SV"
                },
                new DocGia
                {
                    MaDG = "DG003",
                    HoTen = "Nguyễn Đức Anh",
                    GioiTinh = true,
                    NgaySinh = new DateTime(2006, 6, 1),
                    PhiThuongNien = 120000m,
                    MaLoai = "SV"
                },
                new DocGia
                {
                    MaDG = "DG004",
                    HoTen = "Lê Thu Hà",
                    GioiTinh = false,
                    NgaySinh = new DateTime(1985, 11, 19),
                    PhiThuongNien = 200000m,
                    MaLoai = "GV"
                },
                new DocGia
                {
                    MaDG = "DG005",
                    HoTen = "Phạm Quang Huy",
                    GioiTinh = true,
                    NgaySinh = new DateTime(1990, 2, 18),
                    PhiThuongNien = 200000m,
                    MaLoai = "GV"
                }
            );
        }
    }
}
