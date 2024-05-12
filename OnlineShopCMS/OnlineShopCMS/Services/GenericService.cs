using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineShopCMS.Data;
using OnlineShopCMS.Services;
using OnlineShopCMS.Models;
using System.Linq;

public class GenericService<T> : IService<T> where T : class
{
    protected readonly OnlineShopContext _context;
    protected readonly DbSet<T> _dbSet;

    public GenericService(OnlineShopContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    protected DbSet<T> DbSet
    {
        get { return _dbSet; }
    }
    public List<Promotion> GetAllPromotions()
    {
        return _context.Promotions.ToList();
                     
                       
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        _dbSet.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
