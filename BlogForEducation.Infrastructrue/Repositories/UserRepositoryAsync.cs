using BlogForEducation.Domain.Models;
using BlogForEducation.Infrastructrue.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForEducation.Infrastructrue.Repositories
{
    public class UserRepositoryAsync:GenericRepositoryAsync<User>
    {
        private readonly DbSet<User> _users;
        public UserRepositoryAsync(ApplicationDbContext  dbContext):base(dbContext)
        {
            _users = dbContext.Set<User>();
        }
    }
}
