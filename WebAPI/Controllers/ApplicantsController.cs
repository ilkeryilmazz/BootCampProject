using Business.Abstracts;
using Business.Dtos.Requests.Applicant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        IApplicantService _applicantService;

        public ApplicantsController(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _applicantService.GetAllAsync();
            return Ok(result);
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody] CreateApplicantRequest createApplicantRequest)
        {
            var result = await _applicantService.AddAsync(createApplicantRequest);
            return Ok(result);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateApplicantRequest updateApplicantRequest)
        {
            var result = await _applicantService.UpdateAsync(updateApplicantRequest);
            return Ok(result);
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteApplicantRequest deleteApplicantRequest)
        {
            var result = await _applicantService.DeleteAsync(deleteApplicantRequest);
            return Ok(result);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync([FromBody] GetByIdApplicantRequest getByIdApplicantRequest)
        {
            var result = await _applicantService.GetByIdAsync(getByIdApplicantRequest);
            return Ok(result);
        }
    }
}
