using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LapTop.Models
{
    [Table("NHANVIEN")]
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string HoVaTen { get; set; }
        public string SoDienThoai { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string AnhDaiDien { get; set; }
        [Required]
        [StringLength(255)]
        public string TenDangNhap { get; set; }
        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }
        [Required]
        [StringLength(255)]
        [Compare("MatKhau", ErrorMessage = "Xác nhận mật khẩu không chính xác!")]
        [DataType(DataType.Password)]
        public string XacNhanMatKhau { get; set; }
        public int Quyen { get; set; }

        [InverseProperty(nameof(Hoadon.IdnhanVienNavigation))]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
