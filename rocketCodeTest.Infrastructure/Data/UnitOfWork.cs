using rocketCodeTest.Domain.Interfaces;
using rocketCodeTest.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace rocketCodeTest.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private IRepository<User> _userRepository;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userRepository = new Repository<User>(_context); // Inicialización aquí para evitar null
        }

        // Implementación de la propiedad Users
        public IRepository<User> Users => _userRepository;

        // Implementación del método CompleteAsync para guardar cambios
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
