using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Sneat.Models.Datatable;
using System.Linq.Expressions;

namespace Sneat.Context;

public class Repository<TEntity, TContext> : IRepository<TEntity>
    where TEntity : class
    where TContext : MyDBContext
{
    protected TContext _context { get; set; }
    public Repository(TContext context) => _context = context;

    public TEntity Get(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (include != null) queryable = include(queryable);
        return queryable.FirstOrDefault(filter)!;
    }

    public TEntity Add(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Added;
        _context.SaveChanges();
        return entity;
    }

    public void Delete(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public TEntity Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        _context.SaveChanges();
        return entity;
    }

    public void DeleteByFilter(Expression<Func<TEntity, bool>> filter)
    {
        var entity = _context.Set<TEntity>().Where(filter).FirstOrDefault();
        if (entity == null) throw new InvalidOperationException("The specified entity to delete could not be found.");
        _context.Entry(entity).State = EntityState.Deleted;
        _context.SaveChanges();
    }

    public bool IsExist(Expression<Func<TEntity, bool>> filter)
    {
        return _context.Set<TEntity>().Any(filter);
    }

    public ICollection<TEntity> GetAll(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (include != null) queryable = include(queryable);
        if (filter != null) queryable = queryable.Where(filter);
        if (orderBy != null)
            return orderBy(queryable).ToList();
        return queryable.ToList();
    }

    public ICollection<TResult> GetAll<TResult>(
        Expression<Func<TEntity, bool>>? filter = null, 
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, 
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        Expression<Func<TEntity, TResult>>? select = null, 
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (include != null) queryable = include(queryable);
        if (filter != null) queryable = queryable.Where(filter);
        if (orderBy != null) queryable = orderBy(queryable);
        if (select != null) return  queryable.Select(select).ToList();
        return queryable.Cast<TResult>().ToList();
    }

    public DatatableResponseServerSide<TEntity> GetDatatableServerSide(
        Expression<Func<TEntity, bool>>? filter = null,  
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, 
        DatatableRequest dataTableRequest = null!, 
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (filter != null) queryable = queryable.Where(filter);
        if (include != null) queryable = include(queryable);
        
        return queryable.ToDatatableServerSide(dataTableRequest);
    }

    public DatatableResponseServerSide<TResult> GetDatatableServerSide<TResult>(
    Expression<Func<TEntity, bool>>? filter = null,
    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    DatatableRequest dataTableRequest = null!,
    Expression<Func<TEntity, TResult>> select = null!,
    bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (filter != null) queryable = queryable.Where(filter);
        if (include != null) queryable = include(queryable);
        
        return queryable.Select(select).ToDatatableServerSide(dataTableRequest);
    }

    public DatatableResponseClientSide<TEntity> GetDatatableClientSide(
    Expression<Func<TEntity, bool>>? filter = null,
    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (filter != null) queryable = queryable.Where(filter);
        if (include != null) queryable = include(queryable);

        return queryable.ToDatatableClientSide();
    }

    public DatatableResponseClientSide<TResult> GetDatatableClientSide<TResult>(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        Expression<Func<TEntity, TResult>> select = null!,
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = _context.Set<TEntity>();
        if (!enableTracking) queryable = queryable.AsNoTracking();
        if (filter != null) queryable = queryable.Where(filter);
        if (include != null) queryable = include(queryable);

        return queryable.Select(select).ToDatatableClientSide();
    }

    //public Paginate<TEntity> GetPaginatedList(
    //    Expression<Func<TEntity, bool>>? filter = null,
    //    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
    //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    //    int index = default,
    //    int size = default,
    //    bool enableTracking = true)
    //{
    //    IQueryable<TEntity> queryable = _context.Set<TEntity>();
    //    if (!enableTracking) queryable = queryable.AsNoTracking();
    //    if (include != null) queryable = include(queryable);
    //    if (filter != null) queryable = queryable.Where(filter);
    //    if (orderBy != null)
    //        return orderBy(queryable).ToPaginate(index, size);
    //    return queryable.ToPaginate(index, size);
    //}

    //public ICollection<TEntity> GetAllByDynamic(
    //    DynamicQuery dynamicQuery,
    //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    //    bool enableTracking = true)
    //{
    //    IQueryable<TEntity> queryable = _context.Set<TEntity>().AsQueryable().ToDynamic(dynamicQuery);
    //    if (!enableTracking) queryable = queryable.AsNoTracking();
    //    if (include != null) queryable = include(queryable);
    //    return queryable.ToList();
    //}

    //public Paginate<TEntity> GetPaginatedListByDynamic(
    //    DynamicQuery dynamicQuery,
    //    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
    //    int index = default,
    //    int size = default,
    //    bool enableTracking = true)
    //{
    //    IQueryable<TEntity> queryable = _context.Set<TEntity>().AsQueryable().ToDynamic(dynamicQuery);
    //    if (!enableTracking) queryable = queryable.AsNoTracking();
    //    if (include != null) queryable = include(queryable);
    //    return queryable.ToPaginate(index, size);
    //} 
}
