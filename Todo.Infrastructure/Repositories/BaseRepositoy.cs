


using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;
using Todo.Infrastructure.Context;

namespace Todo.Infrastructure.Repositories
{
    public class BaseRepository<T> :IBaseRepository<T> where T : class
    {
       private readonly TodoDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(TodoDbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }

        public async Task<T> AddAsync(T entity)
        {

            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();    
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IQueryable<T> query = _dbSet.AsNoTracking();
            if(typeof(T) == typeof(TodoItem))
            {
                query=query.Include(t=>((TodoItem)(object)t).Category);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> SearchAsync(string searchTerm)
        {
            if (typeof(T) == typeof(TodoItem))
            {
                return await _dbContext.Set<TodoItem>().Include(t => t.Category).Where(b => EF.Functions.Like(b.Title, $"%{searchTerm}%")).Cast<T>().ToListAsync();
            }
            else
            {
                throw new InvalidOperationException("Nothing found");
            }

                
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }

    
   
}
