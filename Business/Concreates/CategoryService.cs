using System.Linq.Expressions;
using Business.Abstracts;
using DataAccsess.Abstracts;
using Entities.Models;

namespace Business.Concreates;

public class CategoryService:ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public bool Add(Category entity)
    {
        if (entity.Name.Length>5)
        {
            var result=_categoryRepository.Add(entity);
            if (result)
            {
                return true;
            }

            
        }
     

        return false;
    }

    public bool Delete(int id)
    {

        _categoryRepository.Delete(id);
        return true;
    }

    public bool Update(Category entity)
    {
       var result= _categoryRepository.Update(entity);
       if (result)
       {
           return true;
       }

       return false;
    }

    public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
    {
        var result = _categoryRepository.GetAll();
        return result;
    }

    public Category GetById(int id)
    {
        return _categoryRepository.GetById(id);
    }
}