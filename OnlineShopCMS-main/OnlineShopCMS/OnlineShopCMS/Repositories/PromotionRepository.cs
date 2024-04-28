using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Data;
using OnlineShopCMS.Models;

namespace OnlineShopCMS.Repositories
{
    public class PromotionRepository : IPromotionRepository
    {
        private readonly OnlineShopContext _context;

        public PromotionRepository(OnlineShopContext context)
        {
            _context = context;
        }

        public async Task<Promotion> GetPromotionAsync(int id)
        {
            return await _context.Promotions.FindAsync(id);
        }

        public async Task<IEnumerable<Promotion>> GetAllPromotionsAsync()
        {
            return await _context.Promotions.ToListAsync();
        }

        public async Task<bool> CreatePromotionAsync(Promotion promotion)
        {
            try
            {
                _context.Promotions.Add(promotion);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdatePromotionAsync(Promotion promotion)
        {
            try
            {
                _context.Entry(promotion).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeletePromotionAsync(int id)
        {
            var promotion = await _context.Promotions.FindAsync(id);
            if (promotion == null)
                return false;

            try
            {
                _context.Promotions.Remove(promotion);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
