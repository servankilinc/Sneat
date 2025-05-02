using Microsoft.EntityFrameworkCore.Query;
using Sneat.Models.Datatable;
using System.Linq.Expressions;

namespace Sneat.Context;


public interface IRepository<TEntity> where TEntity : class
{
    TEntity Get(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    void Delete(TEntity entity);
    void DeleteByFilter(Expression<Func<TEntity, bool>> filter);
    bool IsExist(Expression<Func<TEntity, bool>> filter);


    ICollection<TEntity> GetAll(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool enableTracking = true
    );

    ICollection<TResult> GetAll<TResult>(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        Expression<Func<TEntity, TResult>>? select = null,
        bool enableTracking = true
    );

    DatatableResponseServerSide<TEntity> GetDatatableServerSide(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        DatatableRequest dataTableRequest = null!,
        bool enableTracking = true
    );

    DatatableResponseServerSide<TResult> GetDatatableServerSide<TResult>(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        DatatableRequest dataTableRequest = null!,
        Expression<Func<TEntity, TResult>> select = null!,
        bool enableTracking = true
    );

    DatatableResponseClientSide<TEntity> GetDatatableClientSide(
        Expression<Func<TEntity, bool>>? filter = null, 
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, 
        bool enableTracking = true);

    DatatableResponseClientSide<TResult> GetDatatableClientSide<TResult>(
        Expression<Func<TEntity, bool>>? filter = null, 
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, 
        Expression<Func<TEntity, TResult>> select = null!, 
        bool enableTracking = true);


    //Paginate<TEntity> GetPaginatedList(
    //    Expression<Func<TEntity, bool>>? filter = null,
    //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
    //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    //    int index = default,
    //    int size = default,
    //    bool enableTracking = true
    //);

    //ICollection<TEntity> GetAllByDynamic(
    //    DynamicQuery dynamicQuery,
    //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    //    bool enableTracking = true
    //);

    //Paginate<TEntity> GetPaginatedListByDynamic(
    //    DynamicQuery dynamicQuery,
    //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    //    int index = default,
    //    int size = default,
    //    bool enableTracking = true
    //);
}