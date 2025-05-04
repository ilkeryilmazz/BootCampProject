using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
   public interface IApplicantService
    {
        Task<List<GetAllApplicantResponse>> GetAllAsync();
        Task<CreateApplicantResponse> AddAsync(CreateApplicantRequest createApplicantRequest);
        Task<UpdateApplicantResponse> UpdateAsync(UpdateApplicantRequest updateApplicantRequest);
        Task<DeleteApplicantResponse> DeleteAsync(DeleteApplicantRequest deleteApplicantRequest);
        Task<GetByIdApplicantResponse> GetByIdAsync(GetByIdApplicantRequest getByIdApplicantRequest);
    }
}
