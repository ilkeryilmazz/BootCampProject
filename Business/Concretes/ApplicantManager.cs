using Business.Abstracts;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ApplicantManager : IApplicantService
    {
        IApplicantRepository _applicantRepository;

        public ApplicantManager(IApplicantRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        public async Task<CreateApplicantResponse> AddAsync(CreateApplicantRequest createApplicantRequest)
        {
            Applicant applicant = new Applicant
            {
                About = createApplicantRequest.About,
                DateOfBirth = createApplicantRequest.DateOfBirth,
                NationalIdentity = createApplicantRequest.NationalIdentity,
                Password = createApplicantRequest.Password,
                FirstName = createApplicantRequest.FirstName,
                LastName = createApplicantRequest.LastName,
                Email = createApplicantRequest.Email,
            
            };
            var result = await _applicantRepository.AddAsync(applicant);
            return new CreateApplicantResponse { Id = result.Id };
        }

        public async Task<DeleteApplicantResponse> DeleteAsync(DeleteApplicantRequest deleteApplicantRequest)
        {
            var applicant = await _applicantRepository.GetAsync(x => x.Id == deleteApplicantRequest.Id);

            var deletedApplicant = await _applicantRepository.DeleteAsync(applicant);

            return new DeleteApplicantResponse
            {
                Id = deletedApplicant.Id,
                DeletedAt = DateTime.UtcNow,
            };
        }

        public async Task<List<GetAllApplicantResponse>> GetAllAsync()
        {
            var applicants =await  _applicantRepository.GetAllAsync();
            List<GetAllApplicantResponse> responses = new List<GetAllApplicantResponse>();
            foreach (var applicant in applicants)
            {
                responses.Add(new GetAllApplicantResponse
                {
                    Id = applicant.Id,
                    FirstName = applicant.FirstName,
                    LastName = applicant.LastName,
                    Email = applicant.Email,
                   
                    About = applicant.About,
                });
            }
            return responses;

        }

        public async Task<GetByIdApplicantResponse> GetByIdAsync(GetByIdApplicantRequest getByIdApplicantRequest)
        {
           var applicant = await _applicantRepository.GetAsync(x => x.Id == getByIdApplicantRequest.Id);
          
           return new GetByIdApplicantResponse
           {
               Id = applicant.Id,
               FirstName = applicant.FirstName,
               LastName = applicant.LastName,
               Email = applicant.Email,

               About = applicant.About,
           };
        }

        public async Task<UpdateApplicantResponse> UpdateAsync(UpdateApplicantRequest updateApplicantRequest)
        {
            var applicant = await _applicantRepository.GetAsync(x => x.Id == updateApplicantRequest.Id, tracking:false);
            var updatedApplicant = new Applicant
            {
                Id = updateApplicantRequest.Id,
                FirstName= applicant.FirstName,
                LastName = applicant.LastName,
                NationalIdentity = applicant.NationalIdentity,
                DateOfBirth = applicant.DateOfBirth,
               
                Email = updateApplicantRequest.Email,
                About = updateApplicantRequest.About,
                Password = updateApplicantRequest.Password,

                UpdatedAt = DateTime.UtcNow,
            };

            var result = await _applicantRepository.UpdateAsync(updatedApplicant);

            return new UpdateApplicantResponse
            {
                Id = result.Id,
                Password = result.Password,
                UpdatedAt = result.UpdatedAt,
                Email = result.Email,
                About = result.About,
                
            };
        }
    }
}
