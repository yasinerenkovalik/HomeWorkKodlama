using Core.Repository;
using DataAccsess.Abstracts;
using Entities.Models;

namespace DataAccsess.Concreates;

public class CourseRepository:GenericRepository<Course>, ICourseRepository
{
    public CourseRepository(Context context) : base(context)
    {
    }
}