using System.Collections.Generic;

public class PaginatedResult<T>
{
    public int AllElementsCount { get; set; }
    public int CurrentPage { get; set; }
    public int ElementsPerPage { get; set; }
    public List<T> Data { get; set; }
}