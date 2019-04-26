using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public interface IBaseRepository<T>
    {
        Task<int> AddAsync(T obj);
        Task<int> EditAsync(T obj);
        Task<int> DeleteAsync(int id);
        Task<ICollection<T>> ListAsync();
        Task<T> GetByIdAsync(int id);
    }
}
