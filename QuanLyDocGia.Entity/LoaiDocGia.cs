using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyDocGia.Entity
{
    public class LoaiDocGia
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string TenLoai { get; set; } = string.Empty;

        public ICollection<DocGia> DocGias { get; set; } = new List<DocGia>();
    }
}
