using InterPlayersTest.Infra.Entitties;
using InterPlayersTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterPlayersTest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]User user)
        {
            if(user.Name == null || user.Password == null)
            {
                return BadRequest();
            }

            var sUser = _userService.Register(user);
        
            return Ok(sUser.Result);
        }

    }
}
