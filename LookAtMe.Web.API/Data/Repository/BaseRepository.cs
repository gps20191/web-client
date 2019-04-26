using LookAtMe.Web.API.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public abstract Task<int> AddAsync(T obj);
        public abstract Task<int> DeleteAsync(int id);
        public abstract Task<int> EditAsync(T obj);        
        public abstract Task<T> GetByIdAsync(int id);
        public abstract Task<ICollection<T>> ListAsync();        
    }
}
