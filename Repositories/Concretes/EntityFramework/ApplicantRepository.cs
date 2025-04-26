using Core.Repositories.Concretes;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework.Contexts;

namespace Repositories.Concretes.EntityFramework
{
    public class ApplicantRepository : EfRepositoryBase<Applicant, Guid, BaseDbContext>, IApplicantRepository
    {
        public ApplicantRepository(BaseDbContext context) : base(context)
        {
        }
    }

}
