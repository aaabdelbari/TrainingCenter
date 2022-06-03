using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TrainingCenter.Domain.Interfaces;
using TrainingCenter.Infra.Data.Context;

namespace TrainingCenter.Infra.Data.Repository
{
	public class BaseRepository<T, TKey> : IBaseRepository<T, TKey> where T : class
			where TKey : struct
	{
        protected DbSet<T> DbSet { get; private set; }
        protected TrainingCenterDbContext Context { get; private set; }

        public BaseRepository(TrainingCenterDbContext context)
		{
            this.Context = context;
            this.DbSet = Context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await DbSet.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await DbSet.Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetAsync(TKey id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            DbSet.Remove(entity);
        }

        public async Task RemoveAsync(TKey id)
        {
            T entity = await DbSet.FindAsync(id);
            if (entity == null)
                return;

            DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            DbSet.RemoveRange(entities);
        }
    }
}

