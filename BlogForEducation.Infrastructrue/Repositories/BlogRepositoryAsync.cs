using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructrue.Context;
using BlogForEducation.Infrastructrue.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForEducation.Infrastructrue.Repositories
{
    public class BlogRepositoryAsync : GenericRepositoryAsync<Blog>,IBlogRepositoryAsync
    {
        private readonly DbSet<Blog> _blogs;
        public BlogRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _blogs = dbContext.Set<Blog>();
        } 
        
    }
}
