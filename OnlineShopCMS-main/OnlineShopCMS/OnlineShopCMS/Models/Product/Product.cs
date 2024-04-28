using OnlineShopCMS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopCMS.Models
{
    public class Product
    {
        public int Id { get; set; }                 // Id

        public string Name { get; set; }            // 商品名稱
        public string Description { get; set; }     // 商品簡介
        public string Content { get; set; }         // 商品內容
        public int Price { get; set; }              // 商品價格
        public int Stock { get; set; }              // 商品庫存
        public byte[] Image { get; set; }           // 商品圖片

        public int CategoryId { get; set; }         // 類別 (Foreign Key)
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }

        // 應用促銷代碼
        public int? PromotionId { get; set; }
        public bool IsActive { get; set; } // 新增加的活動狀態屬性

        public ICollection<PromotionProduct> PromotionProducts { get; set; }


        public bool ApplyPromotionCode(IPromotionService promotionService, string promotionCode)
        {
            return promotionService.ApplyPromotionCode(promotionCode);
        }

        // 計算應用促銷後的價格
        public decimal CalculateDiscountedPrice(IPromotionService promotionService)
        {
            // 調用促銷服務中的計算折扣方法
            decimal discountedPrice = Price - promotionService.CalculateDiscount(Price);
            return discountedPrice < 0 ? 0 : discountedPrice; // 確保價格不會為負值
        }
    }
    public enum DiscountType
    {
        Percentage,    // Typically maps to 0
        Amount,        // Typically maps to 1
        BuyOneGetOneFree, // Maps to 2
        BuyXGetY,      // Maps to 3
        Other          // Maps to 4
    }



}
