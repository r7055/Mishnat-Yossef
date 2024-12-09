using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceService;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            List<User> users = _userService.GetAll();
            if (users == null) return new List<User>();
            return users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            if (id == null)
                return BadRequest();
            User user = _userService.Get(id);
            if (user == null)
                return NotFound();
            return user;
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<bool> AddUser([FromBody] User user)
        {
            if (user == null) return BadRequest();
            return _userService.Add(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Update(int id, [FromBody] User user)
        {
            if (user == null||id==null) return BadRequest();
            return _userService.Update(id,user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            if (id == null)
                return BadRequest();
            return _userService.Delete(id);
        }
    }
}
