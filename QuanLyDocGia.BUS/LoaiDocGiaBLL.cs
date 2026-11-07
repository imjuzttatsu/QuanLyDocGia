using System.Collections.Generic;
using QuanLyDocGia.DAL;
using QuanLyDocGia.Entity;

namespace QuanLyDocGia.BUS
{
    public class LoaiDocGiaBLL
    {
        private readonly LoaiDocGiaRepository _loaiDocGiaRepo = new LoaiDocGiaRepository();

        public List<LoaiDocGia> GetAll()
        {
            return _loaiDocGiaRepo.GetAll();
        }
    }
}
