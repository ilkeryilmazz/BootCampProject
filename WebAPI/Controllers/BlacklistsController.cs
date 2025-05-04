using Business.Abstracts;
using Business.Dtos.Requests.Blacklist;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlacklistsController : ControllerBase
    {
        IBlacklistService _blacklistService;

        public BlacklistsController(IBlacklistService blacklistService)
        {
            _blacklistService = blacklistService;
        }
        [HttpGet("GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _blacklistService.GetAllAsync();
            return Ok(result);
        }
        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync([FromBody] CreateBlacklistRequest createBlacklistRequest)
        {
            var result = await _blacklistService.AddAsync(createBlacklistRequest);
            return Ok(result);
        }
        [HttpDelete("DeleteAsync")]
        public async Task<IActionResult> DeleteAsync([FromBody] DeleteBlacklistRequest deleteBlacklistRequest)
        {
            var result = await _blacklistService.DeleteAsync(deleteBlacklistRequest);
            return Ok(result);
        }
        [HttpPut("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateBlacklistRequest updateBlacklistRequest)
        {
            var result = await _blacklistService.UpdateAsync(updateBlacklistRequest);
            return Ok(result);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync([FromBody] GetByIdBlacklistRequest getByIdBlacklistRequest)
        {
            var result = await _blacklistService.GetByIdAsync(getByIdBlacklistRequest);
            return Ok(result);
        }

    }
}
