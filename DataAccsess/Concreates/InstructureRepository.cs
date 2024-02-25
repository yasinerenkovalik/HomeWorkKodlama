using Core.Repository;
using DataAccsess.Abstracts;
using Entities.Models;

namespace DataAccsess.Concreates;

public class InstructureRepository:GenericRepository<Instructor>, IInstructureRepository
{
    public InstructureRepository(Context context) : base(context)
    {
    }
}