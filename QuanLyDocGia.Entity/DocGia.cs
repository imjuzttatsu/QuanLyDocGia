using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDocGia.Entity
{
    public class DocGia
    {
        [Key]
        [StringLength(20)]
        public string MaDG { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = string.Empty;

        public bool GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PhiThuongNien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; } = string.Empty;

        [ForeignKey(nameof(MaLoai))]
        public LoaiDocGia? LoaiDocGia { get; set; }
    }
}
