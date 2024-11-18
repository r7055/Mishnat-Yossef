using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            List<User> users = _userService.GetUsers();
            if (users == null) return new List<User>();
            return users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            User user = _userService.GetUserById(id);
            if (user == null)
                return NotFound();
            return user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<bool> AddUser([FromBody] User user)
        {
            return _userService.AddUser(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Update(int id, [FromBody] User user)
        {
            return _userService.UpdateUserById(user, id);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id < 0)
                return BadRequest();
            return _userService.DeleteUser(id);
        }
    }
}
