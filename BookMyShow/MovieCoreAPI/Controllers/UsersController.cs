using BookMyShowBLL.Services;
using BookMyShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUsers")]
        public IEnumerable<Users> GetUsers()
        {
            return _userService.GetUsers();
        }

        [HttpGet("GetUsersById")]
        public Users GetUsersById(int userId)
        {
            return _userService.GetUsernById(userId);
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] Users users)
        {
            _userService.AddUser(users);
            return Ok("User detail added successfully");
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int userId)
        {
            _userService.DeleteUser(userId);
            return Ok("User detail deleted successfully");
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] Users users)
        {
            _userService.UpdateUser(users);
            return Ok("User detail updated successfully");
        }
    }
}
