using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LapTop.Models
{
    public class CartItem
    {
        public Sanpham Sanpham { get; set; }
        public int Quantity { get; set; }
    }

    public class DonHangCuaToi
    {
        public Hoadon Hoadon { get; set; }
        public int IdDH { get; set; }
        public string TenSanPham { get; set; }
        public string AnhSanPham { get; set; }
        public Nullable<int> GiaBan { get; set; }
        public Nullable<short> SoLuongMua { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public short? TinhTrang { get; set; }

    }
}
