using Business.Abstracts;
using Business.Dtos.Requests.User;
using Business.Dtos.Responses.User;
using Core.Entities;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

       
      

        public async Task<GetByIdUserResponse> GetById(GetByIdUserRequest getByIdUserRequest)
        {
            var result = await _userRepository.GetAsync(user=>user.Id==getByIdUserRequest.Id);
            return new GetByIdUserResponse
            {
                Id = result.Id,
                FirstName = result.FirstName,
                LastName = result.LastName,
                Email = result.Email,
                Password = result.Password,
                DateOfBirth = result.DateOfBirth,
                NationalIdentity = result.NationalIdentity,
            };
        }

     
    }
}
