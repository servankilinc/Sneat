using Sneat.Models.Datatable;
using System.Linq.Dynamic.Core;
using System.Xml;

namespace Sneat.Context
{
    public static class QueryDatatableExtension
    {
        public static DatatableResponseServerSide<TData> ToDatatableServerSide<TData>(this IQueryable<TData> query, DatatableRequest dataTableRequest)
        {
            if (dataTableRequest == null) throw new ArgumentNullException(nameof(DatatableRequest));
            var _response = new DatatableResponseServerSide<TData>();
            
            // 1. Toplam Kayıt Sayısını
            int recordsTotal = query.Count();

            // 2. Filtrele Search Parametresi ile
            if (dataTableRequest.Search != null && !string.IsNullOrEmpty(dataTableRequest.Search.Value) && dataTableRequest.Columns != null)
            {
                var props = typeof(TData).GetProperties().Select(p => p.Name).ToDictionary(p => p.ToLower(), p => p);
                var searchableColumns = dataTableRequest.Columns.Where(c => c.Searchable && !string.IsNullOrWhiteSpace(c.Data));
                foreach (var column in searchableColumns)
                {
                    var key = column.Data!.ToLower();
                    if (props.TryGetValue(key, out var actualPropName))
                    {
                        column.Data = actualPropName;
                    }
                }
                var filters = searchableColumns.Select(c => $"{c.Data}.Contains(@0.ToLower())");

                var searchPredicate = string.Join(" OR ", filters);
                query = query.Where(searchPredicate, dataTableRequest.Search.Value.ToLower());
            }

            int recordsFiltered = query.Count();

            // 3. Sıralama İşlemlerini Uygula
            if (dataTableRequest.Order != null && dataTableRequest.Columns != null)
            {
                List<string> orderList = new List<string>();
                foreach (var orderItem in dataTableRequest.Order)
                {
                    var column = dataTableRequest.Columns[orderItem.Column];
                    if (column != null && column.Orderable && !string.IsNullOrEmpty(column.Data)) 
                        orderList.Add($"{column.Data} {orderItem.Dir}");
                }
                if(orderList.Count > 0)
                {
                    string concatedOrders = string.Join(",", orderList);
                    query = query.OrderBy(concatedOrders);
                }
            }

            // 4. Sayfalama Bilgilerini Uygula
            query = query.Skip(dataTableRequest.Start).Take(dataTableRequest.Length);

            return new DatatableResponseServerSide<TData>
            {
                Data = query.ToList(),
                Draw = dataTableRequest.Draw,
                RecordsTotal = recordsTotal,
                RecordsFiltered = recordsFiltered,
            };
        }

        public static DatatableResponseClientSide<TData> ToDatatableClientSide<TData>(this IQueryable<TData> query)
        {
            return new DatatableResponseClientSide<TData>()
            {
                Data = query.ToList(),
            };
        }
    }
}
