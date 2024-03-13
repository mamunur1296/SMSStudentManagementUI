using Microsoft.EntityFrameworkCore;
using SMS.DataAccessLayer.Data;
using SMS.DataAccessLayer.InfrastructureDb.IRepository;
using System.Linq.Expressions;

namespace SMS.DataAccessLayer.InfrastructureDb.Repository
{
    public class GRepository<T> : IGRepository<T> where T : class
    {
        private readonly ApplicationDbContext _ApplicationDbContext;
        private DbSet<T> _dbSet;

        public GRepository(ApplicationDbContext applicationDbContext)
        {
            _ApplicationDbContext = applicationDbContext;
            _dbSet = _ApplicationDbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
             await _dbSet.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate)
        {
            return  await _dbSet.Where(predicate).FirstOrDefaultAsync();
        }

        public async Task RemoveAllAsync(IEnumerable<T> values)
        {
             _dbSet.RemoveRange(values);
        }

        public async Task RemoveAsync(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
