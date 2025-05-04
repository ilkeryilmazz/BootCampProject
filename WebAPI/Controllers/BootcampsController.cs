using Business.Abstracts;
using Business.Dtos.Requests.Bootcamp;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BootcampsController : Controller
    {
        IBootcampService _bootcampService;

        public BootcampsController(IBootcampService bootcampService)
        {
            _bootcampService = bootcampService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var data = await _bootcampService.GetAllAsync();
            return Ok(data);
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody]CreateBootcampRequest createBootcampRequest)
        {
            var data = await _bootcampService.AddAsync(createBootcampRequest);
            return Ok(data);
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteBootcampRequest deleteBootcampRequest)
        {
            var data = await _bootcampService.DeleteAsync(deleteBootcampRequest);
            return Ok(data);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateBootcampRequest updateBootcampRequest)
        {
            var data = await _bootcampService.UpdateAsync(updateBootcampRequest);
            return Ok(data);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync([FromBody] GetByIdBootcampRequest getByIdBootcampRequest)
        {
            var data = await _bootcampService.GetByIdAsync(getByIdBootcampRequest);
            return Ok(data);
        }

    }
}
