using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBootcampService 
    {
        Task<List<GetAllBootcampResponse>> GetAllAsync();
        Task<CreateBootcampResponse> AddAsync(CreateBootcampRequest createBootcampRequest);
        Task<UpdateBootcampResponse> UpdateAsync(UpdateBootcampRequest updateBootcampRequest);
        Task<DeleteBootcampResponse> DeleteAsync(DeleteBootcampRequest deleteBootcampRequest);
        Task<GetByIdBootcampResponse> GetByIdAsync(GetByIdBootcampRequest getByIdBootcampRequest);
    }
}
