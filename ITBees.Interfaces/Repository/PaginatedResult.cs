using System.Collections.Generic;

namespace ITBees.Interfaces.Repository;

public class PaginatedResult<T>
{
    public int AllElementsCount { get; set; }
    public int AllPagesCount { get; set; }
    public int CurrentPage { get; set; }
    public int ElementsPerPage { get; set; }
    public ICollection<T> Data { get; set; }
}