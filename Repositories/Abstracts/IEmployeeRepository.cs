using Core.Repositories.Abstracts;
using Entities.Concretes;

namespace Repositories.Abstracts
{
    public interface IEmployeeRepository : IAsyncRepository<Employee, Guid>
    {

    }

}