using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineShopCMS.Areas.Identity.Data;
using OnlineShopCMS.Data;
using OnlineShopCMS.Models;
using OnlineShopCMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace OnlineShopCMS.Controllers
{

    [Authorize(Roles = "Administrator")]


    public class OrderController : Controller
    {
        private readonly OnlineShopContext _context;
        private readonly IConfiguration _config;
        private readonly IOrderService _orderService;
        private readonly UserManager<OnlineShopUser> _userManager;

        public OrderController(OnlineShopContext context, IConfiguration config, IOrderService orderService, UserManager<OnlineShopUser> userManager)
        {
            _context = context;
            _config = config;
            _orderService = orderService;
            _userManager = userManager;

        }


        public async Task<IActionResult> Index()
        {
            var orders = await _context.Order.ToListAsync();

            return View(orders);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }

            Order order = await _context.Order.FindAsync(id);

            if (order == null)
            {
                return RedirectToAction("Error");
            }

            return View(order);

        }

        public IActionResult FailOrders()
        {
            var orders = _context.Order.Where(o => o.OrderStatus == OrderStatus.Cancelled).ToList();

            return View(orders);
        }

        public async Task<IActionResult> Search(SearchCriteria criteria)
        {
            List<Order> orders = await _orderService.SearchOrdersAsync(criteria);
            SearchViewModel model = new SearchViewModel
            {
                Criteria = criteria,
                SearchResult = orders
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Search(SearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                List<Order> orders = await _orderService.SearchOrdersAsync(model.Criteria);
                model.SearchResult = orders;
            }

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                return PartialView("_SearchResults", model.SearchResult);
            }

            return View(model);
        }






        [HttpPost]
        public async Task<IActionResult> SearchOrders(SearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var orders = await _orderService.SearchOrdersAsync(new SearchCriteria { UserId = userId });

                return View("Search", orders);
            }
            else
            {
               
                return View();
            }
        }

     



        public async Task<IActionResult> EditOrder(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }

            Order order = await _context.Order.FindAsync(id);

            if (order == null)
            {
                return RedirectToAction("Error");
            }

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, [Bind("Id,OrderDate,UserId,UserName,ReceiverName,ReceiverAddress,ReceiverPhone,Total,IsPaid,IsShipped,ShippingDate")] Order order)
        {
            if (id != order.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Order.Remove(order);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]

        public IActionResult ShipOrder(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }

            Order order = _context.Order.Find(id);

            if (order == null)
            {
                return RedirectToAction("Error");
            }

            // 更新訂單狀態為已發貨
            order.IsShipped = true;

            order.ShippingDate = DateTime.Now;


            // 在實際應用中，你可能還需要更新一些其他的出貨相關信息，例如出貨日期等

            _context.SaveChanges();

            // 重定向到訂單詳細頁面或其他頁面
            return RedirectToAction("Details", "Order", new { id = order.Id });
        }


        [HttpGet]
        public IActionResult GetUnprocessedOrders()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> GetUnprocessedOrdersAsync()
        {
            // 從數據庫中查詢未成立的訂單
            var unprocessedOrders = await _context.Order
                .Where(o => !o.IsPaid)  // 根據 IsPaid 屬性過濾未成立的訂單
                .OrderByDescending(o => o.OrderDate)  // 根據訂單日期降序排序
                .ToListAsync();

            // 將訂單轉換為視圖模型
            var orderViewModels = new List<OrderViewModel>();
            foreach (var order in unprocessedOrders)
            {
                var orderViewModel = new OrderViewModel
                {
                    Order = order,
                    CartItems = await GetOrderItemsAsync(order.Id)
                };
                orderViewModels.Add(orderViewModel);
            }

            return View(orderViewModels);
        }

     

        private async Task<List<CartItem>> GetOrderItemsAsync(int orderId)

        {// 從數據庫中查詢訂單項目
            OnlineShopContext db = new OnlineShopContext();
            var orderItems = await _context.Order
                .Include(o => o.OrderItems)
                .Where(o => o.Id == orderId)
                .SelectMany(o => o.OrderItems)
                .ToListAsync();



            // 將訂單項目轉換為購物車項目
            var cartItems = new List<CartItem>();
            foreach (var orderItem in orderItems)
            {
                // 假設這裡需要查詢產品信息
                // 這裡省略了查詢產品信息的邏輯，假設產品信息存在 Product 表中
                var product = await _context.Product.FindAsync(orderItem.ProductId);

                var cartItem = new CartItem
                {
                    product = product,
                    Amount = orderItem.Amount,
                    SubTotal = orderItem.SubTotal
                };
                cartItems.Add(cartItem);
            }

            return cartItems;
        }
    }
}

