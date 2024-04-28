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
using System.Net;
using System.Threading.Tasks;
using System.Web;


namespace OnlineShopCMS.Controllers
{
    // TODO: 完成 PromotionController
    [Authorize(Roles = "Administrator")]
    public class PromotionController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IPromotionService _promotionService;
        private readonly OnlineShopContext _context;
        private readonly UserManager<OnlineShopUser> _userManager;



        public PromotionController(IPromotionService promotionService, OnlineShopContext context, UserManager<OnlineShopUser> userManager, IConfiguration config)
        {
            _promotionService = promotionService;
            _context = context;
            _userManager = userManager;
            _config = config;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            // 從服務層中獲取所有促銷活動
            var promotions = _promotionService.GetAllPromotions().ToList();
            ViewBag.Products = _context.Product.ToList();

            // 進行對促銷活動屬性的處理
            foreach (var promotion in promotions)
            {
                if (promotion.DiscountType != null)
                {
                    // 對 DiscountType 不為空的情況進行處理
                }

                if (promotion.DiscountValue != null)
                {
                    // 對 DiscountValue 不為空的情況進行處理
                }

                // 其他屬性的處理方式類似
            }

            // 將處理過的促銷活動列表傳遞給視圖
            return View(promotions);
        }
        // GET: Promotion/Create
        public IActionResult Create()
        {
            var products = _context.Product.ToList();
            if (!products.Any())
            {
              
                TempData["Error"] = "No products available. Please add products before creating promotions.";
                return RedirectToAction("Index");
            }

            ViewBag.Products = products;
            return View(new Promotion());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Promotion promotion)
        {
            var products = _context.Product.ToList();
            ViewBag.Products = products;

            if (!products.Any())
            {
                TempData["Error"] = "No products available. Please add products before creating promotions.";
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                _context.Promotions.Add(promotion);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(promotion);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var promotion = await _context.Promotions.FindAsync(id);
            if (promotion == null)
            {
                return NotFound();
            }
            return View(promotion);
        }

        // POST: Promotion/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Code,StartDate,EndDate,IsActive")] Promotion promotion)
        {
            if (id != promotion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   
                    var existingPromotion = await _context.Promotions.FindAsync(id);
                    if (existingPromotion == null)
                    {
                        return NotFound();
                    }

                   
                    existingPromotion.Name = promotion.Name;
                    existingPromotion.Description = promotion.Description;
                    existingPromotion.Code = promotion.Code;
                    existingPromotion.StartDate = promotion.StartDate;
                    existingPromotion.EndDate = promotion.EndDate;
                    existingPromotion.IsActive = promotion.IsActive;

                   
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PromotionExists(promotion.Id))
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
            return View(promotion);
        }




        private bool PromotionExists(int id)
        {
            return _context.Promotions.Any(e => e.Id == id);
        }


    }
}
