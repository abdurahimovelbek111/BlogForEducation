using BlogForEducation.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Application.Interfaces
{
    public interface IBlogServices
    {
        Task<IList<BlogDto>> GetAllBlogAsync();
        Task<BlogDto> GetByIdAsync(int id);
    } 
}
