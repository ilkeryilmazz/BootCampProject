using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;

namespace Repositories.Concretes.EntityFramework
{
    public class InsturctorRepository : EfRepositoryBase<Instructor, Guid, BaseDbContext>, IInstructorRepository
    {
        public InsturctorRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
