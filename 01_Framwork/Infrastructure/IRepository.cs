using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using _01_Framwork.Domain;

namespace _01_Framwork.Infrastructure
{
    public interface IRepository<in Tkey, T> where T : DomainBase<Tkey>
    {
        void Create(T entity);
        T Get(Tkey id);
        List<T> GetAll();
        bool Exists(Expression<Func<T, bool>> expression);
    }
}