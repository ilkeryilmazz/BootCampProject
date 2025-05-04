using Core.Repositories.Abstracts;
using Entities.Concretes;

namespace Repositories.Abstracts
{
    public interface IBlacklistRepository : IAsyncRepository<Blacklist, Guid>
    {

    }


}
