using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructrue.Context;
using BlogForEducation.Infrastructrue.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlogForEducation.Infrastructrue.Repositories
{
    public class UserRepositoryAsync:GenericRepositoryAsync<User>,IUserRepositoryAsync
    {
        private readonly DbSet<User> _users;
        public UserRepositoryAsync(ApplicationDbContext  dbContext):base(dbContext)
        {
            _users = dbContext.Set<User>();
        }       

        public async Task<Blog> CreateBlogAsync(Blog blog, int id)
        {
            var user = await _users.Include(user=>user.Blogs).FirstOrDefaultAsync(user => user.Id == id);
            if (user is null)
            {
                return null;
            }
            user.Blogs.Add(blog);
            await SaveChangesAsync();
            return blog;
        }
    }
}
