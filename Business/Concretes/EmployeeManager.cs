using Business.Abstracts;
using Business.Dtos.Requests.Employee;
using Business.Dtos.Responses.Employee;
using Entities.Concretes;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<CreateEmployeeResponse> AddAsync(CreateEmployeeRequest createEmployeeRequest)
        {
            var employee = new Employee
            {
                FirstName = createEmployeeRequest.FirstName,
                LastName = createEmployeeRequest.LastName,
                Email = createEmployeeRequest.Email,
                DateOfBirth = createEmployeeRequest.DateOfBirth,
                NationalIdentity = createEmployeeRequest.NationalIdentity,
                Password = createEmployeeRequest.Password,
                Position = createEmployeeRequest.Position,
                
                CreatedAt = DateTime.UtcNow,
            };
            var result = await _employeeRepository.AddAsync(employee);
            return new CreateEmployeeResponse
            {
                Id = result.Id,
               
            };
        }

        public async Task<DeleteEmployeeResponse> DeleteAsync(DeleteEmployeeRequest deleteEmployeeRequest)
        {
            var employee = await _employeeRepository.GetAsync(x => x.Id == deleteEmployeeRequest.Id);
            var deletedEmployee = await _employeeRepository.DeleteAsync(employee);
            return new DeleteEmployeeResponse
            {
                Id = deletedEmployee.Id,
                DeletedAt = DateTime.UtcNow,
            };

        }

        public async Task<List<GetAllEmployeeResponse>> GetAllAsync()
        {
            var employees =await _employeeRepository.GetAllAsync();
            List<GetAllEmployeeResponse> responses = new List<GetAllEmployeeResponse>();
            foreach (var employee in employees)
            {
                responses.Add(new GetAllEmployeeResponse
                {
                    Id = employee.Id,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                   
                    Position = employee.Position,
                });
            }
            return responses;
        }

        public async Task<GetByIdEmployeeResponse> GetByIdAsync(GetByIdEmployeeRequest getByIdEmployeeRequest)
        {
            var employee =await _employeeRepository.GetAsync(x => x.Id == getByIdEmployeeRequest.Id);

            return new GetByIdEmployeeResponse
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
               
                Position = employee.Position,
            };
        }

        public async Task<UpdateEmployeeResponse> UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest)
        {
            var employee = await _employeeRepository.GetAsync(x => x.Id == updateEmployeeRequest.Id);
            
            var updatedEmployee = new Employee
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = updateEmployeeRequest.Email,
                DateOfBirth = employee.DateOfBirth,
                NationalIdentity = employee.NationalIdentity,
                Password = updateEmployeeRequest.Password,
                Position = updateEmployeeRequest.Position,

                UpdatedAt = DateTime.UtcNow,
            };
            var result = await _employeeRepository.UpdateAsync(updatedEmployee);
            return new UpdateEmployeeResponse
            {
                Id = result.Id,
                Email = result.Email,
                Position = result.Position,
                Password = result.Password,

            };
        }
    }
}
