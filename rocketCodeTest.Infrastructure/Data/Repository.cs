using Microsoft.EntityFrameworkCore;
using rocketCodeTest.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rocketCodeTest.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

       
    }
}
