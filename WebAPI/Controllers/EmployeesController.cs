using Business.Abstracts;
using Business.Dtos.Requests.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _employeeService.GetAllAsync();
            return Ok(result);
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody] CreateEmployeeRequest createEmployeeRequest)
        {
            var result = await _employeeService.AddAsync(createEmployeeRequest);
            return Ok(result);
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteEmployeeRequest deleteEmployeeRequest)
        {
            var result = await _employeeService.DeleteAsync(deleteEmployeeRequest);
            return Ok(result);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateEmployeeRequest updateEmployeeRequest)
        {
            var result = await _employeeService.UpdateAsync(updateEmployeeRequest);
            return Ok(result);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync([FromBody] GetByIdEmployeeRequest getByIdEmployeeRequest)
        {
            var result = await _employeeService.GetByIdAsync(getByIdEmployeeRequest);
            return Ok(result);
        }
    }
}
