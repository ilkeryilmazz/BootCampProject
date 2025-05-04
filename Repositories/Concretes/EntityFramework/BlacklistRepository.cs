using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;

namespace Repositories.Concretes.EntityFramework
{
    public class BlacklistRepository : EfRepositoryBase<Blacklist, Guid, BaseDbContext>, IBlacklistRepository
    {
        public BlacklistRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
