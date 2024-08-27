using System;
using System.Collections.Generic;
using System.Linq;

namespace ITBees.Interfaces.Repository;

public class PaginatedResult<T>
{
    public int AllElementsCount { get; set; }
    public int AllPagesCount { get; set; }
    public int CurrentPage { get; set; }
    public int ElementsPerPage { get; set; }
    public ICollection<T> Data { get; set; }

    public PaginatedResult()
    {
        Data = new List<T>();
    }

    public PaginatedResult(int allElementsCount, int allPagesCount, int currentPage, int elementsPerPage, ICollection<T> data)
    {
        AllElementsCount = allElementsCount;
        AllPagesCount = allPagesCount;
        CurrentPage = currentPage;
        ElementsPerPage = elementsPerPage;
        Data = data;
    }

    public PaginatedResult<TDestination> MapTo<TDestination>(Func<T, TDestination> mapFunction)
    {
        return new PaginatedResult<TDestination>
        {
            AllElementsCount = this.AllElementsCount,
            AllPagesCount = this.AllPagesCount,
            CurrentPage = this.CurrentPage,
            ElementsPerPage = this.ElementsPerPage,
            Data = this.Data.Select(mapFunction).ToList()
        };
    }
}
