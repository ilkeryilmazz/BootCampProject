using Business.Dtos.Requests.Employee;
using Business.Dtos.Responses.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
   public interface IEmployeeService
    {
        Task<List<GetAllEmployeeResponse>> GetAllAsync();
        Task<CreateEmployeeResponse> AddAsync(CreateEmployeeRequest createEmployeeRequest);
        Task<UpdateEmployeeResponse> UpdateAsync(UpdateEmployeeRequest updateEmployeeRequest);
        Task<DeleteEmployeeResponse> DeleteAsync(DeleteEmployeeRequest deleteEmployeeRequest);
        Task<GetByIdEmployeeResponse> GetByIdAsync(GetByIdEmployeeRequest getByIdEmployeeRequest);
    }
}
