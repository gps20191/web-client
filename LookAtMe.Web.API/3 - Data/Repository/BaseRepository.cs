using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LookAtMe.Web.API.Data.Context;
using LookAtMe.Web.API.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LookAtMe.Web.API.Data.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public virtual void Add(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public abstract void Delete(int id);

        public virtual void Edit(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual Task<List<T>> GetAllAsync()
        {
            var x = _context.Set<T>().ToListAsync();
            return x;
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        IQueryable<T> IBaseRepository<T>.GetBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }
    }
}
