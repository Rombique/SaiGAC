using SaiGAC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SaiGAC.DAL.Repositories
{
    interface IGenericRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        T GetById(int id);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Remove(int id);
    }
}
