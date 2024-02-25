using System.Linq.Expressions;
using Business.Abstracts;
using DataAccsess.Abstracts;
using Entities.Models;

namespace Business.Concreates;

public class CourseService:ICourseService
{
    private readonly ICourseRepository _courseRepository;
    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }
    public bool Add(Course entity)
    {
        _courseRepository.Add(entity);
        return true;
    }

    public bool Delete(int id)
    {
        _courseRepository.Delete(id);
        return true;
    }

    public bool Update(Course entity)
    {
        _courseRepository.Update(entity);
        return true;
    }

    public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
    {
        return _courseRepository.GetAll();
    }

    public Course GetById(int id)
    {
        return _courseRepository.GetById(id);
    }
}