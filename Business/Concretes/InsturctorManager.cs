using Business.Abstracts;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Applicant;
using Business.Dtos.Responses.Instructor;
using Entities.Concretes;
using Repositories.Abstracts;
using Repositories.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
   public class InsturctorManager:IInstructorService
    {
        IInstructorRepository _instructorRepository;
        
        public InsturctorManager(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
          
        }

        public async Task<CreatetInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest)
        {


            Instructor instructor = new Instructor
            {
                FirstName = createInstructorRequest.FirstName,
                LastName = createInstructorRequest.LastName,
                Email = createInstructorRequest.Email,
                NationalIdentity = createInstructorRequest.NationalIdentity,
                Password = createInstructorRequest.Password,
                DateOfBirth = createInstructorRequest.DateOfBirth,
                CompanyName = createInstructorRequest.CompanyName,
                CreatedAt = DateTime.UtcNow,
               
            };

            var result = await _instructorRepository.AddAsync(instructor);

            return new CreatetInstructorResponse
            {
                
                Id = result.Id,
               
            };
        }

        public async Task<DeleteInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest)
        {
            var instructor = await _instructorRepository.GetAsync(x => x.Id == deleteInstructorRequest.Id);

            var deletedInstructor = await _instructorRepository.DeleteAsync(instructor);

            return new DeleteInstructorResponse
            {
                Id = deletedInstructor.Id,
                DeletedAt = DateTime.UtcNow,
            };
        }

        public async Task<List<GetAllInstructorResponse>> GetAllAsync()
        {
            var instructors = await _instructorRepository.GetAllAsync(x=>x.DeletedAt==null);
            List<GetAllInstructorResponse> responses = new List<GetAllInstructorResponse>();

            foreach (var instructor in instructors)
            {
                responses.Add(new GetAllInstructorResponse
                {
                    Id = instructor.Id,
                    FirstName = instructor.FirstName,
                    LastName = instructor.LastName,
                    Email = instructor.Email,
                    
                    CompanyName = instructor.CompanyName,
                });
            }

            return responses;
        }

        public async Task<GetByIdInstructorResponse> GetByIdAsync(GetByIdInstructorRequest getByIdInstructorRequest)
        {
            var instructor = await _instructorRepository.GetAsync(x => x.Id == getByIdInstructorRequest.Id && x.DeletedAt==null);
            return new GetByIdInstructorResponse
            {
                Id = instructor.Id,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                Email = instructor.Email,
               
                CompanyName = instructor.CompanyName,
            };
        }

        public async Task<UpdateInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest)
        {
            var instructor = await _instructorRepository.GetAsync(x => x.Id == updateInstructorRequest.Id, tracking: false);
            var updatedInstructor = new Instructor
            {
                Id = updateInstructorRequest.Id,
                FirstName = instructor.FirstName,
                LastName = instructor.LastName,
                NationalIdentity = instructor.NationalIdentity,
                DateOfBirth = instructor.DateOfBirth,

                Email = updateInstructorRequest.Email,
                CompanyName = updateInstructorRequest.CompanyName,
                Password = updateInstructorRequest.Password,

                UpdatedAt = DateTime.UtcNow,
            };

            var result = await _instructorRepository.UpdateAsync(updatedInstructor);

            return new UpdateInstructorResponse
            {
                Id = result.Id,
                Password = result.Password,
                UpdatedAt = result.UpdatedAt,
                Email = result.Email,
                CompanyName = result.CompanyName,

            };
        }
    }
}
