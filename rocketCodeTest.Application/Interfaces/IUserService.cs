using rocketCodeTest.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rocketCodeTest.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();

        Task AddUserAsync(User user);

    }
}
