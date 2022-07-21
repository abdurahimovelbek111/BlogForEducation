using BlogForEducation.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogForEducation.Infrastructrue.Interfaces
{
    public interface IGenericRepositoryAsync<T> where T:class
    {
       public Task<T> GetByIdAsync(int id,IList<string> includes);
       public Task<IReadOnlyList<T>> GetAllAsync();
       public Task<IReadOnlyList<T>> GetPagedListAsync(int pageNumber,int pageSize);
       public Task<T> AddAsync(T entity);
       public Task UpdateAsync(T entity);
       public Task DeleteAsync(T entity);
    }
}
