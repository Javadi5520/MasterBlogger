using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using _01_Framwork.Domain;
using Microsoft.EntityFrameworkCore;

namespace _01_Framwork.Infrastructure
{
    public class BaseRepository<Tkey, T> : IRepository<Tkey, T> where T : DomainBase<Tkey>
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add<T>(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public T Get(Tkey id)
        {
            return _context.Find<T>(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}