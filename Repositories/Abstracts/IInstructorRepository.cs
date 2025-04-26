using Core.Repositories.Abstracts;
using Entities.Concretes;

namespace Repositories.Abstracts
{
    public interface IInstructorRepository : IAsyncRepository<Instructor, Guid>
    {

    }

}