using AuthServer.Core.DTOs;
using AuthServer.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SharedLibrary.Dtos;
using System.Threading.Tasks;

namespace AuthServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<Response<UserAppDto>>> CreateUser(CreateUserDto createUserDto)
        {
            return ActionResultInstance(await _userService.CreateUserAsync(createUserDto));
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<Response<UserAppDto>>> GetUser()
        {
            return ActionResultInstance(await _userService.GetUserByNameAsync(HttpContext.User.Identity.Name));
        }
    }
}
