# QuanLyDocGia

Ứng dụng Quản lý độc giả viết bằng C# WinForms trên nền tảng .NET 8, áp dụng kiến trúc 3 lớp (3-Layer Architecture) kết hợp Entity Framework Core (Code First).

## Các chức năng chính
- Quản lý danh sách độc giả (Thêm, Sửa, Xóa, Làm mới).
- Hiển thị danh sách độc giả lên DataGridView kèm định dạng giới tính, ngày sinh, phí thường niên và loại độc giả.
- Kiểm tra tính hợp lệ của dữ liệu đầu vào theo quy định.

## Cấu trúc Solution
- QuanLyDocGia.Entity: Định nghĩa các thực thể dữ liệu (DocGia, LoaiDocGia).
- QuanLyDocGia.DAL: Tầng truy xuất dữ liệu (DbContext, Migrations, Repository).
- QuanLyDocGia.BUS: Tầng xử lý nghiệp vụ và kiểm tra hợp lệ dữ liệu.
- QuanLyDocGia.GUI: Giao diện người dùng Windows Forms.

## Cài đặt và sử dụng
1. Mở solution `QuanLyDocGia.sln` bằng Visual Studio 2022 (yêu cầu .NET 8.0 SDK).
2. Kiểm tra chuỗi kết nối trong file `App.config` (cấu hình sẵn kết nối Microsoft SQL Server / LocalDB).
3. Chạy lệnh cập nhật cơ sở dữ liệu nếu cần: `dotnet ef database update --project QuanLyDocGia.DAL --startup-project QuanLyDocGia.GUI`.
4. Build và chạy project `QuanLyDocGia.GUI`.
