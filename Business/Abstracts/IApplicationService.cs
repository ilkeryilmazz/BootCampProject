using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IApplicationService
    {
        Task<List<GetAllApplicationResponse>> GetAllAsync();
        Task<CreateApplicationResponse> AddAsync(CreateApplicationRequest createApplicationRequest);
        Task<UpdateApplicationResponse> UpdateAsync(UpdateApplicationRequest updateApplicationRequest);
        Task<DeleteApplicationResponse> DeleteAsync(DeleteApplicationRequest deleteApplicationRequest);
        Task<GetByIdApplicationResponse> GetByIdAsync(GetByIdApplicationRequest getByIdApplicationRequest);
    }
}
