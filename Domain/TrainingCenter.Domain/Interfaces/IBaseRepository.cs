using System;
using System.Linq.Expressions;

namespace TrainingCenter.Domain.Interfaces
{
	public interface IBaseRepository<T, TKey> where T : class
            where TKey : struct
	{
        Task<T> GetAsync(TKey id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Remove(T entity);
        Task RemoveAsync(TKey id);
        void RemoveRange(IEnumerable<T> entities);
    }
}

