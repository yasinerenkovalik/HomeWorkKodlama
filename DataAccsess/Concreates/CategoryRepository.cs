using Core.Repository;
using DataAccsess.Abstracts;
using Entities.Models;

namespace DataAccsess.Concreates;

public class CategoryRepository:GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(Context context) : base(context)
    {
    }
}