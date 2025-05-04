using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;

namespace Repositories.Concretes.EntityFramework
{
    public class ApplicationRepository : EfRepositoryBase<Application, Guid, BaseDbContext>, IApplicationRepository
    {
        public ApplicationRepository(BaseDbContext context) : base(context)
        {
        }
    }



}