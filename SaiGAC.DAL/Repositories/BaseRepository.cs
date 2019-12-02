using SaiGAC.DAL.Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace SaiGAC.DAL.Repositories
{
    public class BaseRepository<T> : IGenericRepository<T> where T : class, new()
    {
        protected readonly SQLiteConnection Connection;

        public BaseRepository(SQLiteConnection connection)
        {
            Connection = connection;
        }

        public void Add(T entity)
        {
            Connection.Insert(entity);
        }

        public void Dispose()
        {
            Connection.Close();
            Connection.Dispose();
            GC.SuppressFinalize(this);
        }

        public IEnumerable<T> GetAll() => Connection.Table<T>().ToList();

        public T GetById(int id)
        {
            return Connection.Table<T>().FirstOrDefault(t => GetId(t) == id.ToString());
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate) => Connection.Table<T>().Where(predicate);

        public void Remove(int id)
        {
            Connection.Delete<T>(id);
        }

        public void Update(T entity)
        {
            Connection.Update(entity);
        }

        private string GetId(T obj)
        {
            Type t = typeof(T);
            foreach (var property in t.GetRuntimeProperties())
            {
                var attr = (PrimaryKeyAttribute[])property.GetCustomAttributes(typeof(PrimaryKeyAttribute), false);
                if (attr.Length > 0)
                    return property.GetValue(obj).ToString();
            }

            return "";
        }
    }
}
