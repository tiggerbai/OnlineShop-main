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

namespace OnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly OnlineShopContext _context;

        public ProductsController(OnlineShopContext context)
        {
            _context = context;
        }



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
        public async Task<IActionResult> AddComment(int Id, string myComment)
        {
            var comment = new Comment()
            {
                ProductID = Id,
                Content = myComment,
                UserName = HttpContext.User.Identity.Name,  //取得登入中的帳號
                Time = DateTime.Now  //取得當下時間
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
                Product = product
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




    }
}
