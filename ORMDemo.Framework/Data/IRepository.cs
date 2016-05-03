using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ORMDemo.Data
{
    public interface IRepository<T>
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Get(int id);

        T Get(Expression<Func<T, bool>> predicate);

        int Count(Expression<Func<T, bool>> predicate);
    }
}