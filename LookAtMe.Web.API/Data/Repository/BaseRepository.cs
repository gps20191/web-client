using LookAtMe.Web.API.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Domain.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
    {
        public readonly AppDbContext context;

        public abstract Task<T> AddAsync(T obj);
        public abstract Task<T> EditAsync(T obj);
        public abstract Task<T> GetAllAsync();
        public abstract Task<T> GetByIdAsync(int id);      
    }
}
