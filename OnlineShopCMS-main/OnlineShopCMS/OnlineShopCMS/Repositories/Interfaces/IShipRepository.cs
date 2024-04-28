using OnlineShopCMS.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineShopCMS.Repositories
{
    public interface IShipRepository
    {
        Task<Ship> GetByIdAsync(int id);
        Task<List<Ship>> GetAllAsync();
        Task<List<Ship>> GetAsync(Expression<Func<Ship, bool>> predicate);
        Task InsertAsync(Ship entity);
        Task UpdateAsync(Ship entity);
        Task DeleteAsync(Ship entity);
       
    }
}
