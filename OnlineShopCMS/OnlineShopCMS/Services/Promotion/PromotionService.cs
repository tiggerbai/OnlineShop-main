using OnlineShopCMS.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Data;
using OnlineShopCMS.Repositories;

namespace OnlineShopCMS.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly OnlineShopContext _context;
        private readonly IPromotionRepository _promotionRepository;


        public PromotionService(OnlineShopContext context, IPromotionRepository promotionRepository)
        {
            _context = context;
            _promotionRepository = promotionRepository;
        }

        public IEnumerable<Promotion> GetAllPromotions()
        {
            return _context.Promotions
                .Select(p => new Promotion
                {
                    Id = p.Id,
                    Name = p.Name ?? string.Empty,
                    Description = p.Description ?? string.Empty,
                    Code = p.Code ?? string.Empty,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate,
                    IsActive = p.IsActive,
                    DiscountType = p.DiscountType ?? default,
                    DiscountValue = p.DiscountValue.HasValue ? p.DiscountValue.Value : default,
                    // 移除对 TargetType 的引用
                    PromotionRules = p.PromotionRules ?? new List<PromotionRule>(),
                    PromotionProducts = p.PromotionProducts ?? new List<PromotionProduct>(),
                    Conditions = p.Conditions ?? new List<PromotionCondition>()
                })
                .ToList();
        }




        public bool ApplyPromotionCode(string promotionCode)
        {
            // 假設的邏輯：檢查促銷碼是否存在
            var promo = _context.Promotions.FirstOrDefault(p => p.Code == promotionCode);
            return promo != null;
        }

        public decimal CalculateDiscount(decimal totalPrice)
        {
            // 假設的邏輯：總價打九折
            return totalPrice * 0.9m;
        }
    }
}
