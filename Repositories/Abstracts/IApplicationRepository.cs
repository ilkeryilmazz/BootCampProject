using Core.Repositories.Abstracts;
using Entities.Concretes;

namespace Repositories.Abstracts
{
    public interface IApplicationRepository : IAsyncRepository<Application, Guid>
    {

    }


}
