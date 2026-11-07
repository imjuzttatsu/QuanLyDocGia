using System;
using System.Collections.Generic;
using QuanLyDocGia.DAL;
using QuanLyDocGia.Entity;

namespace QuanLyDocGia.BUS
{
    public class DocGiaBLL
    {
        private readonly DocGiaRepository _docGiaRepo = new DocGiaRepository();

        public List<DocGia> GetAll()
        {
            return _docGiaRepo.GetAll();
        }

        public void Add(DocGia docGia)
        {
            if (docGia == null)
            {
                throw new ArgumentNullException(nameof(docGia), "Dữ liệu độc giả không hợp lệ!");
            }

            docGia.MaDG = docGia.MaDG?.Trim() ?? string.Empty;
            docGia.HoTen = docGia.HoTen?.Trim() ?? string.Empty;

            ValidateDocGia(docGia);

            if (_docGiaRepo.Exists(docGia.MaDG))
            {
                throw new InvalidOperationException("Mã độc giả đã tồn tại!");
            }

            _docGiaRepo.Add(docGia);
        }

        public void Update(DocGia docGia)
        {
            if (docGia == null)
            {
                throw new ArgumentNullException(nameof(docGia), "Dữ liệu độc giả không hợp lệ!");
            }

            docGia.MaDG = docGia.MaDG?.Trim() ?? string.Empty;
            docGia.HoTen = docGia.HoTen?.Trim() ?? string.Empty;

            ValidateDocGia(docGia);

            if (!_docGiaRepo.Exists(docGia.MaDG))
            {
                throw new InvalidOperationException("Không tìm thấy độc giả để cập nhật!");
            }

            _docGiaRepo.Update(docGia);
        }

        public void Delete(string maDG)
        {
            string ma = maDG?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(ma))
            {
                throw new ArgumentException("Chưa chọn độc giả để xóa!");
            }

            _docGiaRepo.Delete(ma);
        }

        private void ValidateDocGia(DocGia docGia)
        {
            if (docGia == null)
            {
                throw new ArgumentNullException(nameof(docGia), "Dữ liệu độc giả không hợp lệ!");
            }

            if (string.IsNullOrWhiteSpace(docGia.MaDG))
            {
                throw new ArgumentException("Mã độc giả không được để trống!");
            }

            if (docGia.MaDG.Length > 20)
            {
                throw new ArgumentException("Mã độc giả không quá 20 ký tự!");
            }

            if (string.IsNullOrWhiteSpace(docGia.HoTen))
            {
                throw new ArgumentException("Họ tên không được để trống!");
            }

            if (docGia.HoTen.Length > 100)
            {
                throw new ArgumentException("Họ tên không quá 100 ký tự!");
            }

            if (string.IsNullOrWhiteSpace(docGia.MaLoai))
            {
                throw new ArgumentException("Vui lòng chọn loại độc giả!");
            }

            if (docGia.NgaySinh.Date > DateTime.Today)
            {
                throw new ArgumentException("Ngày sinh không được lớn hơn ngày hiện tại!");
            }

            if (docGia.PhiThuongNien <= 0)
            {
                throw new ArgumentException("Phí thường niên phải là số lớn hơn 0!");
            }
        }
    }
}
