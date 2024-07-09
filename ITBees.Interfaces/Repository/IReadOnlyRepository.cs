using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ITBees.Interfaces.Repository
{
    public interface IReadOnlyRepository<T>
    {

        bool HasData(Expression<Func<T, bool>> predicate);
        T GetFirst(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        ICollection<T> GetData(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includeProperties);

        PaginatedResult<T> GetDataPaginated(Expression<Func<T, bool>> predicate,int page, int elementsPerPage,
            params Expression<Func<T, object>>[] includeProperties);

        int GetDataCount(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetDataQueryable(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetDataQueryable(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        ICollection<T> GetDataFromStoredProcedure(string procedureName, params object[] procedureArgument);
        ICollection<T2> Sql<T2>(string sql) where T2 : class;
    }
}