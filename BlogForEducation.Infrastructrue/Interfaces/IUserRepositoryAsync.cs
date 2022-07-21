using BlogForEducation.Domain.Models;
using System.Threading.Tasks;

namespace BlogForEducation.Infrastructrue.Interfaces
{
    public interface IUserRepositoryAsync:IGenericRepositoryAsync<User>
    {
        Task<Blog> CreateBlogAsync(Blog blog,int id);
    }
}
