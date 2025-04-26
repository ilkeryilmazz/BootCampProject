using Core.Repositories.Abstracts;
using Entities.Concretes;

namespace Repositories.Abstracts
{
    public interface IApplicantRepository : IAsyncRepository<Applicant, Guid>
    {

    }

}