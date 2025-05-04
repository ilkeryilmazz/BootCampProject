using Business.Abstracts;
using Business.Dtos.Requests.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _applicationService.GetAllAsync();
            return Ok(result);
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody] CreateApplicationRequest createApplicationRequest)
        {
            var result = await _applicationService.AddAsync(createApplicationRequest);
            return Ok(result);
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteApplicationRequest deleteApplicationRequest)
        {
            var result = await _applicationService.DeleteAsync(deleteApplicationRequest);
            return Ok(result);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateApplicationRequest updateApplicationRequest)
        {
            var result = await _applicationService.UpdateAsync(updateApplicationRequest);
            return Ok(result);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync([FromBody] GetByIdApplicationRequest getByIdApplicationRequest)
        {
            var result = await _applicationService.GetByIdAsync(getByIdApplicationRequest);
            return Ok(result);
        }
    }
}
