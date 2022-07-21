using BlogForEducation.Application.DTOs;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Interfaces
{
    public interface IUserService
    {
       public Task<IReadOnlyList<UserDto>> GetAllUserAsync();
       public Task<UserDto> GetUserByIdAsync(int id);
       public Task<UserDto> CreateUserAsync(UserForCreationDto user);
        public Task<BlogDto> CreateBlogAsync(BlogForCreationDto blogDto,int userId);
    }
}
