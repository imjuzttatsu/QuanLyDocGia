using System.Collections.Generic;
using System.Linq;
using QuanLyDocGia.Entity;

namespace QuanLyDocGia.DAL
{
    public class LoaiDocGiaRepository
    {
        public List<LoaiDocGia> GetAll()
        {
            using var context = new QuanLyDocGiaDbContext();
            return context.LoaiDocGias.OrderBy(l => l.MaLoai).ToList();
        }
    }
}
