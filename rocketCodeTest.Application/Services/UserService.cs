using rocketCodeTest.Application.Interfaces;
using rocketCodeTest.Domain.Entities;
using rocketCodeTest.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rocketCodeTest.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }



        public async Task AddUserAsync(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
        }

    }
}
