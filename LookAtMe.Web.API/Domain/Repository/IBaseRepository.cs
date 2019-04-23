using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public interface IBaseRepository<T>
    {
        Task<T> AddAsync(T obj);
        Task<T> EditAsync(T obj);
        Task<T> GetByIdAsync(int id);
        Task<T> GetAllAsync();
    }
}
