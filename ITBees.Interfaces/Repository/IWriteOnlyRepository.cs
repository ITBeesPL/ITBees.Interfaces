using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ITBees.Interfaces.Repository
{
    public interface IWriteOnlyRepository<T>
    {
        T InsertData(T entity);
        ICollection<T> InsertData(ICollection<T> includeProperty);

        ICollection<T> UpdateData(Expression<Func<T, bool>> predicate, Action<T> updateAction,
            params Expression<Func<T, object>>[] includeProperties);

        int DeleteData(Expression<Func<T, bool>> predicate);
        void DeleteData(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        void Sql(string sql);
    }
}