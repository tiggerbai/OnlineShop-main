using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShopCMS.Models;

namespace OnlineShopCMS.Repositories
{
    public interface IPromotionRepository
    {
        Task<Promotion> GetPromotionAsync(int id);
        Task<IEnumerable<Promotion>> GetAllPromotionsAsync();
        Task<bool> CreatePromotionAsync(Promotion promotion);
        Task<bool> UpdatePromotionAsync(Promotion promotion);
        Task<bool> DeletePromotionAsync(int id);
    }
}
