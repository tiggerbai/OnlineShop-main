using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopCMS.Data;
using OnlineShopCMS.Services;
using OnlineShopCMS.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopCMS.Controllers
{
    [Authorize(Roles = "Administrator")]

    public class ShippingController : Controller
    {
        private readonly OnlineShopContext _context;

        public ShippingController(OnlineShopContext context)
        {
            _context = context;
            
        }
        // GET: Shipping
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var orders = await _context.Order.ToListAsync();
            return View(orders);
        }
      





        // GET: Shipping/Download
        public IActionResult Download(int orderId)
        {
            var order = _context.Order.FirstOrDefault(o => o.Id == orderId);

            if (order == null)
            {
                return NotFound();
            }

            // 建立提貨單內容
            var shippingContent = $"提貨單\n訂單編號: {order.Id}\n收件人: {order.ReceiverName}\n地址: {order.ReceiverAddress}\n電話: {order.ReceiverPhone}\n";

            // 將提貨單內容寫入暫存檔
            var tempFilePath = Path.GetTempFileName();
            System.IO.File.WriteAllText(tempFilePath, shippingContent);

            // 提供下載連結
            return File(System.IO.File.ReadAllBytes(tempFilePath), "text/plain", $"shipping_{orderId}.txt");
        }
    }
}
