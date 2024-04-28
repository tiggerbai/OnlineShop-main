using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OnlineShopCMS.IRepository
{
    /// <summary>
    /// Repository接口，定義CRUD操作方法
    /// </summary>
    public interface IBaseRepository<T> where T : class, new()
    {
        Task<bool> Insert(T entity);
        Task<bool> DeleteById(int id);
        Task<bool> Update(T entity);
        Task<T> QueryById(int id);
        Task<List<T>> Query();
        Task<List<T>> QueryListByClause(Expression<Func<T, bool>> whereExpression);
    }
}
