using Business.Abstracts;
using Business.Dtos.Requests.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById([FromBody] GetByIdUserRequest getByIdUserRequest)
        {
            var data = _userService.GetById(getByIdUserRequest);
            return Ok(data);
        }


    }
}
