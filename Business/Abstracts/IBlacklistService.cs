using Business.Dtos.Requests.Blacklist;
using Business.Dtos.Responses.Blacklist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
   public interface IBlacklistService
    {
        Task<List<GetAllBlacklistResponse>> GetAllAsync();
        Task<CreateBlacklistResponse> AddAsync(CreateBlacklistRequest createBlacklistRequest);
        Task<UpdateBlacklistResponse> UpdateAsync(UpdateBlacklistRequest updateBlacklistRequest);
        Task<DeleteBlacklistResponse> DeleteAsync(DeleteBlacklistRequest deleteBlacklistRequest);
        Task<GetByIdBlacklistResponse> GetByIdAsync(GetByIdBlacklistRequest getByIdBlacklistRequest);

    }
}
