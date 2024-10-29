using System;

namespace ITBees.Interfaces.Repository;

public static class SortColumnHelper
{
    public static string GetSortColumn<TSortColumn>(TSortColumn sortColumn) where TSortColumn : Enum
    {
        return sortColumn.GetDescription();
    }
}