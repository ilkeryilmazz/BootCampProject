using Business.Abstracts;
using Business.Dtos.Requests.Instructor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsturctorsController : ControllerBase
    {
        IInstructorService _instructorService;

        public InsturctorsController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }
        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _instructorService.GetAllAsync();
          
            return Ok(result);
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody] CreateInstructorRequest createInsturctorRequest)
        {
            var result = await _instructorService.AddAsync(createInsturctorRequest);
           
                return Ok(result);
           
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteInstructorRequest deleteInstructorRequest)
        {
            var result = await _instructorService.DeleteAsync(deleteInstructorRequest);
            return Ok(result);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateInstructorRequest updateInstructorRequest)
        {
            var result = await _instructorService.UpdateAsync(updateInstructorRequest);
            return Ok(result);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync([FromBody] GetByIdInstructorRequest getByIdInstructorRequest)
        {
            var result = await _instructorService.GetByIdAsync(getByIdInstructorRequest);
            return Ok(result);
        }
    }
}
