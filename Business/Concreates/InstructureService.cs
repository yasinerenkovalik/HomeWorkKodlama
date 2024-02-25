using System.Linq.Expressions;
using Business.Abstracts;
using DataAccsess.Abstracts;
using Entities.Models;

namespace Business.Concreates;

public class InstructureService:IInstructureService
{
    private readonly IInstructureRepository _instructureRepository;
    public InstructureService(IInstructureRepository instructureRepository)
    {
        _instructureRepository = instructureRepository;
    }
    public bool Add(Instructor entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Instructor entity)
    {
        throw new NotImplementedException();
    }

    public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public Instructor GetById(int id)
    {
        throw new NotImplementedException();
    }
}