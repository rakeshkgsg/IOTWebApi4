using IotWebApi.Dto;
using IotWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;

namespace IotWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [Authorize]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("list")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        // to be used with syncfusion datamanager
        [HttpPost("read")]
        public ActionResult Read(DataManagerRequest dm)
        {
            return Ok(_userService.GetAllWithDM(dm));
        }

        [HttpGet]
        public IActionResult GetById(string id)
        {
            var user = _userService.GetById(id);
            return Ok(user);
        }

        [HttpGet("username")]
        public IActionResult GetByUsername(string username)
        {
            var user = _userService.GetByUsername(username);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(UserDto u, string password)
        {
            var res = _userService.Create(u, password);
            if (res) return Ok();
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Remove(string id)
        {
            var res = _userService.Remove(id);
            if (res) return Ok();
            return BadRequest();
        }

        [HttpDelete("username")]
        public IActionResult RemoveByUsername(string username)
        {
            var res = _userService.RemoveByUsername(username);
            if (res) return Ok();
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(UserDto u)
        {
            var res = _userService.Update(u);
            if (res) return Ok();
            return BadRequest();
        }
    }
}
