﻿using System;

namespace ITBees.Interfaces.Repository;

public class SortOptions
{
    public SortOptions(int? page, int? elementsPerPage, Enum? sortColumn, SortOrder? sortOrder)
    {
        Page = page ?? 1;
        ElementsPerPage = elementsPerPage ?? 25;
        SortColumn = sortColumn != null ? SortColumnHelper.GetSortColumn(sortColumn) : string.Empty;
        SortOrder = sortOrder ?? SortOrder.Descending;
    }


    public SortOptions(int? page, int? elementsPerPage, string? sortColumn, SortOrder? sortOrder)
    {
        Page = page ?? 1;

        ElementsPerPage = elementsPerPage ?? 25;

        if (sortColumn == null)
        {
            sortColumn = "";
        }
        else
        {
            SortColumn = sortColumn;
        }

        SortOrder = sortOrder ?? SortOrder.Descending;
    }

    public int Page { get; set; }
    public int ElementsPerPage { get; set; }
    public string SortColumn { get; set; }
    public SortOrder SortOrder { get; set; }
}