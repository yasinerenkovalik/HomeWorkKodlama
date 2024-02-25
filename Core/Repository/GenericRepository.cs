using System.Linq.Expressions;
using DataAccsess;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository;

public abstract class GenericRepository<T>:IGenericRepository<T> where T:Entity
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }
    public bool Add(T entity)
    {
        var result= _context.Add(entity);
        if (result.State == EntityState.Added)
        {
            _context.SaveChanges();
            return true;
        }

        return false;

    }

    public bool Delete(int id)
    {
        var entity = _context.Set<T>().Find(id);
        if (entity != null)
        {
            entity.Active = false;
            Update(entity);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public bool Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
        return true;
    }

    public List<T> GetAll(Expression<Func<T, bool>> filter = null)
    {
        IQueryable<T> query = _context.Set<T>();

        if (filter != null)
        {
            query = query.Where(filter);
        }

        return query.ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
}