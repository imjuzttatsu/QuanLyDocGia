using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyDocGia.Entity;

namespace QuanLyDocGia.DAL
{
    public class DocGiaRepository
    {
        public List<DocGia> GetAll()
        {
            using var context = new QuanLyDocGiaDbContext();
            return context.DocGias.Include(d => d.LoaiDocGia).OrderBy(d => d.MaDG).ToList();
        }

        public bool Exists(string maDG)
        {
            using var context = new QuanLyDocGiaDbContext();
            return context.DocGias.Any(d => d.MaDG == maDG);
        }

        public void Add(DocGia docGia)
        {
            using var context = new QuanLyDocGiaDbContext();
            context.DocGias.Add(docGia);
            context.SaveChanges();
        }

        public void Update(DocGia docGia)
        {
            using var context = new QuanLyDocGiaDbContext();
            var existing = context.DocGias.Find(docGia.MaDG);
            if (existing != null)
            {
                existing.HoTen = docGia.HoTen;
                existing.GioiTinh = docGia.GioiTinh;
                existing.NgaySinh = docGia.NgaySinh;
                existing.PhiThuongNien = docGia.PhiThuongNien;
                existing.MaLoai = docGia.MaLoai;
                context.SaveChanges();
            }
        }

        public void Delete(string maDG)
        {
            using var context = new QuanLyDocGiaDbContext();
            var docGia = context.DocGias.Find(maDG);
            if (docGia != null)
            {
                context.DocGias.Remove(docGia);
                context.SaveChanges();
            }
        }
    }
}
