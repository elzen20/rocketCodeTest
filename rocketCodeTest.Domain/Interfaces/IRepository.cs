using System.Collections.Generic;
using System.Threading.Tasks;
using rocketCodeTest.Domain.Entities;

namespace rocketCodeTest.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
    }
     public interface IUnitOfWork : IDisposable
    {
        // Repositorios específicos (si es necesario)
        // Por ejemplo:
        // IUserRepository Users { get; }

        // Métodos de la unidad de trabajo
        IRepository<User> Users { get; }
        Task<int> CompleteAsync();
    }
}
