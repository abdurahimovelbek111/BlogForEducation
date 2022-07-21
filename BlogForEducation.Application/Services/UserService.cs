using AutoMapper;
using BlogForEducation.Application.DTOs;
using BlogForEducation.Application.Interfaces;
using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructrue.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositoryAsync _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepositoryAsync  userrepositoryAsync,IMapper mapper)
        {
            _userRepository = userrepositoryAsync;
            _mapper = mapper;
        }

        public async Task<BlogDto> CreateBlogAsync(BlogForCreationDto blogDto, int userId)
        {
            return _mapper.Map<BlogDto>(await _userRepository.CreateBlogAsync(_mapper.Map<Blog>(blogDto),userId));
        }

        public async Task<UserDto> CreateUserAsync(UserForCreationDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            return _mapper.Map<UserDto>(await _userRepository.AddAsync(user));
        }
        public async Task<IReadOnlyList<UserDto>> GetAllUserAsync()
        {
            return _mapper.Map< IReadOnlyList<UserDto>>(await _userRepository.GetAllAsync());
        }
        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            return _mapper.Map<UserDto>(await _userRepository.GetByIdAsync(id,new List<string>{"Blogs"}));
        }
    }
}
