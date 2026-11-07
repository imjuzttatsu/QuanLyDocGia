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
            context.DocGias.Update(docGia);
            context.SaveChanges();
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
