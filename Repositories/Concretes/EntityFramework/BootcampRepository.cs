using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;

namespace Repositories.Concretes.EntityFramework
{
    public class BootcampRepository : EfRepositoryBase<Bootcamp, Guid, BaseDbContext>, IBootcampRepository
    {
        public BootcampRepository(BaseDbContext context) : base(context)
        {
        }
    }



}
