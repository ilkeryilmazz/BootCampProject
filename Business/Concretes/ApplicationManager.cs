using Business.Abstracts;
using Business.Dtos.Requests.Application;
using Business.Dtos.Responses.Application;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationRepository _applicantRepository;

        public ApplicationManager(IApplicationRepository applicantRepository)
        {
            _applicantRepository = applicantRepository;
        }

        public async Task<CreateApplicationResponse> AddAsync(CreateApplicationRequest createApplicationRequest)
        {
            var application = new Application
            {
                ApplicantId = createApplicationRequest.ApplicantId,
                BootcampId = createApplicationRequest.BootcampId,
              
                ApplicationState = createApplicationRequest.State,
                CreatedAt = DateTime.UtcNow,
            };
            var result = await _applicantRepository.AddAsync(application);
            return new CreateApplicationResponse
            {
                Id = result.Id,
               
            };
        }

        public async Task<DeleteApplicationResponse> DeleteAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            var application = await _applicantRepository.GetAsync(x => x.Id == deleteApplicationRequest.Id, tracking:false);
           var deletedApplication = await _applicantRepository.DeleteAsync(application);
            return new DeleteApplicationResponse
            {
                Id = deletedApplication.Id,
                DeletedAt = DateTime.UtcNow,
            };
        }

        public async Task<List<GetAllApplicationResponse>> GetAllAsync()
        {
            var applications = await  _applicantRepository.GetAllAsync();
            List<GetAllApplicationResponse> responses = new List<GetAllApplicationResponse>();
            foreach (var application in applications)
            {
                responses.Add(new GetAllApplicationResponse
                {
                    Id = application.Id,
                    ApplicantId = application.ApplicantId,
                    BootcampId = application.BootcampId,
                    State = application.ApplicationState,
                });
            }
            return responses;

        }

        public async Task<GetByIdApplicationResponse> GetByIdAsync(GetByIdApplicationRequest getByIdApplicationRequest)
        {
            var application = await _applicantRepository.GetAsync(x => x.Id == getByIdApplicationRequest.Id);
            return new GetByIdApplicationResponse
            {
                Id = application.Id,
                ApplicantId = application.ApplicantId,
                BootcampId = application.BootcampId,
                State = application.ApplicationState,
            };
        }

        public async Task<UpdateApplicationResponse> UpdateAsync(UpdateApplicationRequest updateApplicationRequest)
        {
            var application = await _applicantRepository.GetAsync(x => x.Id == updateApplicationRequest.Id, tracking: false);
            var updatedApplication = new Application
            {
                Id = application.Id,
                ApplicantId = updateApplicationRequest.ApplicantId,
                BootcampId = updateApplicationRequest.BootcampId,
                ApplicationState = updateApplicationRequest.State,
                CreatedAt = DateTime.UtcNow,
            };
            var result = await _applicantRepository.UpdateAsync(updatedApplication);
            return new UpdateApplicationResponse
            {
                Id = result.Id,
                ApplicantId = result.ApplicantId,
                BootcampId = result.BootcampId,
                State = result.ApplicationState,
            };
        }
    }
}
