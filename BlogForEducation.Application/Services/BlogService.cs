using AutoMapper;
using BlogForEducation.Application.DTOs;
using BlogForEducation.Application.Interfaces;
using BlogForEducation.Infrastructrue.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Services
{
    public class BlogService : IBlogServices
    {
        private readonly IBlogRepositoryAsync _blogRepositoryAsync;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepositoryAsync blogRepositoryAsync,IMapper mapper)
        {
            _blogRepositoryAsync = blogRepositoryAsync;
            _mapper = mapper;
        }
        public async Task<IList<BlogDto>> GetAllBlogAsync()
        {
            return _mapper.Map<IList<BlogDto>>(await _blogRepositoryAsync.GetAllAsync());
        }

        public async Task<BlogDto> GetByIdAsync(int id)
        {
            return _mapper.Map<BlogDto>(await _blogRepositoryAsync.GetByIdAsync(, new List<string> { "User" }));
        }
    }
}
