using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAtMe.Web.API.Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Add(T obj);
        IQueryable<T> GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();
        Task<List<T>> GetAllAsync();
        void Edit(T obj);
        void Delete(int id);
        void Save();
    }
}
