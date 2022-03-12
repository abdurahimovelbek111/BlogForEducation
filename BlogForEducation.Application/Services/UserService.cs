using BlogForEducation.Application.Interfaces;
using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructrue.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepositoryAsync<User> _userRepository;
        public UserService(IGenericRepositoryAsync<User>  userrepositoryAsync)
        {
            _userRepository = userrepositoryAsync;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }

        public async Task<IReadOnlyList<User>> GetAllUserAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }
    }
}
