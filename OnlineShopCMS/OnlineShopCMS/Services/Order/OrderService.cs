using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Data;
using OnlineShopCMS.Models;

namespace OnlineShopCMS.Services
{
    public class OrderService : GenericService<Order>, IOrderService
    {
        public OrderService(OnlineShopContext context) : base(context)
        {
        }



        public async Task<List<Order>> GetUnprocessedOrdersAsync()
        {
            return await _context.Order
                .Where(o => !o.IsPaid)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        public async Task<List<Order>> GetFailedOrdersAsync()
        {
            return await _context.Order
                .Where(o => o.OrderStatus == OrderStatus.Cancelled)
                .ToListAsync();
        }

        public async Task<List<Order>> SearchOrdersAsync(SearchCriteria criteria)
        {
            // 這裡是一個基本的搜索實現，你可能需要根據你的需求來調整這個方法
            var query = _context.Order.AsQueryable();

            if (!string.IsNullOrEmpty(criteria.UserId))
            {
                query = query.Where(o => o.UserId == criteria.UserId);
            }

            // 添加其他的搜索條件...

            return await query.ToListAsync();
        }

        public async Task ShipOrderAsync(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order != null)
            {
                order.IsShipped = true;
                order.ShippingDate = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }
    }
}
