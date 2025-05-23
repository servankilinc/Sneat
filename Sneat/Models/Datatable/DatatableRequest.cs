﻿namespace Sneat.Models.Datatable;

public class DatatableRequest
{
    public int Draw { get; set; }
    public int Start { get; set; }
    public int Length { get; set; }
    public Search? Search { get; set; }
    public List<Order>? Order { get; set; }
    public List<Column>? Columns { get; set; }

    public DatatableRequest GetDatatableRequest()
    {
        return this; 
    }
}


public class Search
{
    public string? Value { get; set; }
    public bool Regex { get; set; }
}

public class Order
{
    public int Column { get; set; }
    public string? Dir { get; set; }
}

public class Column
{
    public string? Data { get; set; }
    public string? Name { get; set; }
    public bool Searchable { get; set; } = false;
    public bool Orderable { get; set; }
    public Search? Search { get; set; }
}
