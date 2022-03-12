using BlogForEducation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Interfaces
{
    public interface IUserService
    {
        Task<IReadOnlyList<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> CreateUserAsync(User user);

    }
}
