using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShopCMS.Models;
using OnlineShopCMS.Services;

namespace OnlineShopCMS.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetUnprocessedOrdersAsync();
        Task<List<Order>> GetFailedOrdersAsync();
        Task<List<Order>> SearchOrdersAsync(SearchCriteria criteria);
        Task ShipOrderAsync(int id);
       
    }
}