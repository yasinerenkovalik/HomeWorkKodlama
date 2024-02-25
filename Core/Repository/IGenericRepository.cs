using System.Linq.Expressions;
using Entities;

namespace Core.Repository;

public interface IGenericRepository<T> where T:Entity
{
    bool Add(T entity);
    bool Delete(int id);
    bool Update(T entity);
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T GetById(int id);
}