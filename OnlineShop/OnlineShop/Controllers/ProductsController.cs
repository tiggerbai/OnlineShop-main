using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;

using Microsoft.AspNetCore.Authentication;
<<<<<<< HEAD
using OnlineShop.Helpers;
=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0

namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly OnlineShopContext _context;

        public ProductsController(OnlineShopContext context)
        {
            _context = context;
        }
<<<<<<< HEAD
    
=======

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0


        public async Task<IActionResult> Index(int? cId)
        {
            var productsByCategory = new Dictionary<string, List<DetailViewModel>>();

            List<Product> products = new List<Product>();
            if (cId != null)
            {
                var result = await _context.Category.SingleAsync(x => x.Id.Equals(cId));
                products = await _context.Entry(result).Collection(x => x.Products).Query().ToListAsync();
            }
            else
            {
                products = await _context.Product.Include(p => p.Category).ToListAsync();
            }

            foreach (var product in products)
            {
                DetailViewModel item = new DetailViewModel
                {
                    Product = product
                };

                if (product.Image != null)
                {
                    item.imgsrc = ViewImage(product.Image);
                }

                if (!productsByCategory.ContainsKey(product.Category.Name))
                {
                    productsByCategory[product.Category.Name] = new List<DetailViewModel>();
                }

                productsByCategory[product.Category.Name].Add(item);
            }

            var model = new ProductsByCategoryViewModel
            {
                ProductsByCategory = productsByCategory
            };

            return View(model);
        }

        [HttpPost]
        [Authorize]  //一定要登入才能留言
<<<<<<< HEAD
        public async Task<IActionResult> AddComment(int Id, string myComment, int rating)
=======
        public async Task<IActionResult> AddComment(int Id, string myComment)
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
        {
            var comment = new Comment()
            {
                ProductID = Id,
                Content = myComment,
                UserName = HttpContext.User.Identity.Name,  //取得登入中的帳號
<<<<<<< HEAD
                Time = DateTime.Now,  //取得當下時間
                Ratiing = rating
=======
                Time = DateTime.Now  //取得當下時間
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            };
            _context.Add(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { id = Id });
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _context.Product.Include(c => c.Comments).FirstOrDefaultAsync(m => m.Id == id);
            var product = await _context.Product
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            DetailViewModel dvm = new DetailViewModel
            {
<<<<<<< HEAD
                Product = product,
               AverageRating = product.Comments.Count > 0 ? product.Comments.Average(c => c.Ratiing) : 0

=======
                Product = product
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            };

            if (product.Image != null)
            {
                dvm.imgsrc = ViewImage(product.Image);
            }

            return View(dvm);
        }

        private string ViewImage(byte[] arrayImage)
        {
            string base64String = Convert.ToBase64String(arrayImage, 0, arrayImage.Length);
            return "data:image/png;base64," + base64String;

        }
        public IActionResult ProductImage(int id)
        {
            var product = _context.Product.FirstOrDefault(p => p.Id == id);
            if (product == null || product.Image == null)
            {
                return RedirectToAction("Error"); 
            }

            return File(product.Image, "image/jpeg"); 
        }

        public void GetImage()
        {
            var image = _context.Product.FirstOrDefault().Image;
            string base64String = Convert.ToBase64String(image, 0, image.Length);
            string imgSrc = string.Format("data:image/png;base64,{0}", base64String);
        }

<<<<<<< HEAD
        public IActionResult ApplyCoupon(string couponCode)
        {
            var coupon = _context.Coupon.FirstOrDefault(c => c.Code == couponCode);
            if (coupon == null || coupon.ExpiryDate < DateTime.Now)
            {
                // 折價券無效，返回錯誤訊息
                ViewBag.ErrorMessage = "Invalid coupon code";
                return View(nameof(Index));
            }

            // 應用折價券的折扣
            List<CartItem> CartItems = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");

            if (CartItems != null)
            {
                var total = CartItems.Sum(m => m.SubTotal); // 計算商品總額
                var discount = total * coupon.DiscountAmount / 100; // 計算折扣金額
                ViewBag.Total = total - discount; // 應用折扣
            }
            else
            {
                ViewBag.Total = 0;
            }

            return View("Index", CartItems); // 返回 Index 視圖，並將 CartItems 作為模型
        }


=======
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0



    }
}
