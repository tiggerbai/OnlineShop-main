using OnlineShopCMS.Models;
using System.Collections.Generic;

namespace OnlineShopCMS.Services
{
    public interface IPromotionService
    {
        IEnumerable<Promotion> GetAllPromotions();
        bool ApplyPromotionCode(string promotionCode);
        decimal CalculateDiscount(decimal totalPrice);
        // 其他與促銷相關的方法聲明
    }
}
