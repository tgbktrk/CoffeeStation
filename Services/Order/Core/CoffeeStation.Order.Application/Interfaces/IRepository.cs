using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoffeeStation.Order.Application.Interfaces
{
    public interface IRepository<T>
        where T : class
    {
        Task<List<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        //Entity Framework'te kullanılan filtreleme işleminin lambda ifadesi
        Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter);
    }
}
