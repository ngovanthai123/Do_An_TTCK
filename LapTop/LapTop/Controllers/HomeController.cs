using LapTop.Data;
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

    }
}
