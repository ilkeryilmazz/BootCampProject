
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Applicant;
using Business.Dtos.Responses.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<CreatetInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest);
        Task<List<GetAllInstructorResponse>> GetAllAsync();
        Task<UpdateInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
        Task<DeleteInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest);
        Task<GetByIdInstructorResponse> GetByIdAsync(GetByIdInstructorRequest getByIdInstructorRequest);
    }
}
