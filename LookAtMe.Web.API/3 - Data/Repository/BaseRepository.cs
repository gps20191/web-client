using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LookAtMe.Web.API.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LookAtMe.Web.API.Domain.Repository
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

        public virtual void Delete(T obj)
        {

            _context.Set<T>().Remove(obj);
        }

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

        public virtual T GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query.First();
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

        IQueryable<T> IBaseRepository<T>.GetBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
