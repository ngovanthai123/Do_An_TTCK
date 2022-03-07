using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LapTop.Models
{
    [Table("TINHTRANG")]
    public partial class Tinhtrang
    {
        public Tinhtrang()
        {
            Hoadons = new HashSet<Hoadon>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TinhTrang")]
        public int? TinhTrang1 { get; set; }
        [StringLength(255)]
        public string TenTinhTrang { get; set; }
        [InverseProperty(nameof(Hoadon.IdtinhTrangNavigation))]
        public virtual ICollection<Hoadon> Hoadons { get; set; }
    }
}
