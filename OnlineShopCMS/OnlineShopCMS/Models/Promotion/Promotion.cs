using System.Collections.Generic;
using System;

namespace OnlineShopCMS.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }

        public int? ProductId { get; set; }

        // Enum property
        public DiscountType? DiscountType { get; set; }

        public decimal? DiscountValue { get; set; }

        public decimal CalculateDiscountedPrice(decimal originalPrice)
        {
            // 根據 DiscountType 和 DiscountValue 計算折扣價格
            if (DiscountType.HasValue && DiscountValue.HasValue)
            {
                if (DiscountType.HasValue && DiscountType.Value == Models.DiscountType.Percentage)
                {
                    return (decimal)(originalPrice * (1 - (DiscountValue.Value / 100)));
                }
                else if (DiscountType.Value == Models.DiscountType.Amount) // 對於固定金額折扣
                {
                    return (decimal)(originalPrice - DiscountValue.Value);
                }
            }
            return originalPrice;
        }
        public ICollection<PromotionProduct> PromotionProducts { get; set; }

        public virtual ICollection<PromotionTarget> PromotionTargets { get; set; }

        public List<PromotionRule> PromotionRules { get; set; }
        public List<PromotionCondition> Conditions { get; set; }
    }

}
