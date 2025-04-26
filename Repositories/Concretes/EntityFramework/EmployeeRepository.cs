using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;

namespace Repositories.Concretes.EntityFramework
{
    public class EmployeeRepository : EfRepositoryBase<Employee, Guid, BaseDbContext>, IEmployeeRepository
    {
        public EmployeeRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
