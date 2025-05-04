using Business.Abstracts;
using Business.Dtos.Requests.Blacklist;
using Business.Dtos.Responses.Blacklist;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BlacklistManager : IBlacklistService
    {
        IBlacklistRepository _blacklistRepository;

        public BlacklistManager(IBlacklistRepository blacklistRepository)
        {
            _blacklistRepository = blacklistRepository;
        }

        public async Task<CreateBlacklistResponse> AddAsync(CreateBlacklistRequest createBlacklistRequest)
        {
            var blacklist = new Blacklist
            {
                ApplicantId = createBlacklistRequest.ApplicantId,
                Reason = createBlacklistRequest.Reason,
                Date = createBlacklistRequest.Date,
                CreatedAt = DateTime.UtcNow,
            };
            var result = await _blacklistRepository.AddAsync(blacklist);
            return new CreateBlacklistResponse
            {
                Id = result.Id,
               
            };


        }

        public async Task<DeleteBlacklistResponse> DeleteAsync(DeleteBlacklistRequest deleteBlacklistRequest)
        {
            var blacklist = _blacklistRepository.GetAsync(x => x.Id == deleteBlacklistRequest.Id);
            var deletedBlacklist = await _blacklistRepository.DeleteAsync(blacklist.Result);
            return new DeleteBlacklistResponse
            {
                Id = deletedBlacklist.Id,
                DeletedAt = DateTime.UtcNow,
            };
        }

        public async Task<List<GetAllBlacklistResponse>> GetAllAsync()
        {
           var blacklists = await _blacklistRepository.GetAllAsync();
            List<GetAllBlacklistResponse> responses = new List<GetAllBlacklistResponse>();
            foreach (var blacklist in blacklists)
            {
                responses.Add(new GetAllBlacklistResponse
                {
                    Id = blacklist.Id,
                    ApplicantId = blacklist.ApplicantId,
                    Reason = blacklist.Reason,
                    Date = blacklist.Date,
                });
            }
            return responses;
        }

        public async Task<GetByIdBlacklistResponse> GetByIdAsync(GetByIdBlacklistRequest getByIdBlacklistRequest)
        {
            var blacklist = await _blacklistRepository.GetAsync(x => x.Id == getByIdBlacklistRequest.Id);
            return new GetByIdBlacklistResponse
            {
                Id = blacklist.Id,
                ApplicantId = blacklist.ApplicantId,
                Reason = blacklist.Reason,
                Date = blacklist.Date,
            };

        }

        public async Task<UpdateBlacklistResponse> UpdateAsync(UpdateBlacklistRequest updateBlacklistRequest)
        {
            var blacklist = await _blacklistRepository.GetAsync(x => x.Id == updateBlacklistRequest.Id, tracking:false);
            var updatedBlacklist = new Blacklist
            {
                Id = updateBlacklistRequest.Id,
                ApplicantId = updateBlacklistRequest.ApplicantId,
                Reason = updateBlacklistRequest.Reason,
                Date = updateBlacklistRequest.Date,
                CreatedAt = DateTime.UtcNow,
            };
            var result = await _blacklistRepository.UpdateAsync(updatedBlacklist);
            return new UpdateBlacklistResponse
            {
                Id = result.Id,
                ApplicantId = result.ApplicantId,
                Reason = result.Reason,
                Date = result.Date,
            };
        }
    }
}
