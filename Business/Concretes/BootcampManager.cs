using Business.Abstracts;
using Business.Dtos.Requests.Bootcamp;
using Business.Dtos.Responses.Bootcamp;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BootcampManager : IBootcampService
    {
        IBootcampRepository _bootcampRepository;

        public BootcampManager(IBootcampRepository bootcampRepository)
        {
            _bootcampRepository = bootcampRepository;
        }

        public async Task<CreateBootcampResponse> AddAsync(CreateBootcampRequest createBootcampRequest)
        {
            Bootcamp bootcamp = new Bootcamp
            {
                Name = createBootcampRequest.Name,
               
                StartDate = createBootcampRequest.StartDate,
                EndDate = createBootcampRequest.EndDate,
                InstructorId = createBootcampRequest.InstructorId,
                BootcampState = createBootcampRequest.State,
                CreatedAt = DateTime.UtcNow,

            };
            var result = await _bootcampRepository.AddAsync(bootcamp);

            return new CreateBootcampResponse
            {
                Id = result.Id,
              
            };
        }

        public async Task<DeleteBootcampResponse> DeleteAsync(DeleteBootcampRequest deleteBootcampRequest)
        {
            var bootcamp = await _bootcampRepository.GetAsync(x => x.Id == deleteBootcampRequest.Id);
            var deletedBootcamp = _bootcampRepository.DeleteAsync(bootcamp);
            return new DeleteBootcampResponse
            {
                Id = deletedBootcamp.Result.Id,
                DeletedAt = DateTime.UtcNow,
            };
        }

        public async Task<List<GetAllBootcampResponse>> GetAllAsync()
        {

            var bootcamps = await _bootcampRepository.GetAllAsync();
            List<GetAllBootcampResponse> reponses = new List<GetAllBootcampResponse>();
            foreach (var bootcamp in bootcamps)
            {
                reponses.Add(new GetAllBootcampResponse
                {
                    Id = bootcamp.Id,
                    Name = bootcamp.Name,
                    StartDate = bootcamp.StartDate,
                    EndDate = bootcamp.EndDate,
                   
                });
            }

            return reponses;

        }

        public async Task<GetByIdBootcampResponse> GetByIdAsync(GetByIdBootcampRequest getByIdBootcampRequest)
        {
           var bootcamp = await _bootcampRepository.GetAsync(x=>x.Id == getByIdBootcampRequest.Id);
            
           
            return new GetByIdBootcampResponse
            {
                Id = bootcamp.Id,
                Name = bootcamp.Name,
                StartDate = bootcamp.StartDate,
                EndDate = bootcamp.EndDate,
                
            };
        }

        public async Task<UpdateBootcampResponse> UpdateAsync(UpdateBootcampRequest updateBootcampRequest)
        {
            var bootcamp = _bootcampRepository.GetAsync(x => x.Id == updateBootcampRequest.Id, tracking:false);

            var updatedBootcamp = new Bootcamp
            {
                Id = updateBootcampRequest.Id,
                Name = updateBootcampRequest.Name,
                StartDate = updateBootcampRequest.StartDate,
                EndDate = updateBootcampRequest.EndDate,
                InstructorId = updateBootcampRequest.InstructorId,
                BootcampState = updateBootcampRequest.State,
                CreatedAt =  DateTime.UtcNow,
            };

            var result = await _bootcampRepository.UpdateAsync(updatedBootcamp);
            return new UpdateBootcampResponse
            {
                Id = result.Id,
                Name = result.Name,
                StartDate = result.StartDate,
                EndDate = result.EndDate,
                State = result.BootcampState,
                InstructorId = result.InstructorId,
            };
        }
    }
}
