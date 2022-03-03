using LapTop.Data;
using LapTop.Library;
using LapTop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LapTop.Controllers
{
    public class HomeController : Controller
    {
        const string SessionMand = "_Id";
        const string SessionHoten = "_HoVaTen";
        const string SessionTenDN = "_TenDN";

        public const string CARTKEY = "shopcart";

        private readonly ILogger<HomeController> _logger;
        private readonly LAPTOPContext _context;
        private LAPTOPContext db = new LAPTOPContext();

        public HomeController(ILogger<HomeController> logger, LAPTOPContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Lưu danh sách CartItem trong giỏ hàng vào session
        void SaveCartSession(List<CartItem> list)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(list);
            session.SetString("LAPTOP", jsoncart);
        }

        // Đọc danh sách CartItem từ session
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("LAPTOP");
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Cho hàng vào giỏ
        public async Task<IActionResult> AddToCart(int id)
        {
            var sp = await _context.Sanphams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sp == null)
            {
                return NotFound("Sản phẩm không tồn tại");
            }
            var cart = GetCartItems();
            var item = cart.Find(p => p.Sanpham.Id == id);
            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                cart.Add(new CartItem() { Sanpham = sp, Quantity = 1 });
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        // Chuyển đến view xem giỏ hàng
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }

        // Xóa một mặt hàng khỏi giỏ
        public IActionResult RemoveItem(int id)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.Sanpham.Id == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        // Cập nhật số lượng một mặt hàng trong giỏ
        public IActionResult UpdateItem(int id, int quantity)
        {
            var cart = GetCartItems();
            var item = cart.Find(p => p.Sanpham.Id == id);
            if (item != null)
            {
                item.Quantity = quantity;
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        public IActionResult CheckOut()
        {
            return View(GetCartItems());
        }



        public ActionResult Login()
        {
            ModelState.AddModelError("LoginError", "");
            return View();
        }


        // POST: Home/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(KhachHangLogin khachHang)
        {
            if (ModelState.IsValid)
            {
                string mahoamatkhau = SHA1.ComputeHash(khachHang.MatKhau);
                var taiKhoan = db.Khachhangs.Where(r => r.TenDangNhap == khachHang.TenDangNhap && r.MatKhau == mahoamatkhau).SingleOrDefault();

                if (taiKhoan == null)
                {
                    ModelState.AddModelError("LoginError", "Tên đăng nhập hoặc mật khẩu không chính xác!");
                    return View(khachHang);
                }
                else
                {
                    // Đăng ký SESSION

                    HttpContext.Session.SetInt32(SessionMand, taiKhoan.Id);
                    HttpContext.Session.SetString(SessionHoten, taiKhoan.HoVaTen);
                    HttpContext.Session.SetString(SessionTenDN, taiKhoan.TenDangNhap);


                    // Quay về trang chủ
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(khachHang);
        }

        public ActionResult Logout()
        {
            // Xóa SESSION
            HttpContext.Session.Remove("_Id");
            HttpContext.Session.Remove("_Hoten");
            HttpContext.Session.Remove("_TenDN");
            HttpContext.Session.Remove(CARTKEY);

            // Quy về trang chủ
            return RedirectToAction("Login", "Home");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("Id,HoVaTen,DienThoai,DiaChi,Email,TenDangNhap,MatKhau,XacNhanMatKhau")] Khachhang khachHang)
        {
            if (ModelState.IsValid)
            {
                var check = db.Khachhangs.FirstOrDefault(r => r.TenDangNhap == khachHang.TenDangNhap);
                if (check == null)
                {

                    khachHang.MatKhau = SHA1.ComputeHash(khachHang.MatKhau);
                    khachHang.XacNhanMatKhau = SHA1.ComputeHash(khachHang.XacNhanMatKhau);
                    _context.Add(khachHang);
                    await _context.SaveChangesAsync();
                    ModelState.AddModelError("SignUpError", "Đăng ký thành công!");
                    return RedirectToAction(nameof(Login));

                }
                else
                {
                    ViewBag.error = "Tên đăng nhập đã tồn tại !!! Bạn hãy chọn tên khác!!!!";
                    return View();
                }
            }
            return View();
        }
        public IActionResult SignUp()
        {
            ModelState.AddModelError("SignUpError", "");
            return View();
        }
    }
}
