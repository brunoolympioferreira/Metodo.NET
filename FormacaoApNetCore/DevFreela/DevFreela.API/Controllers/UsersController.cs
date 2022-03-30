using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        public UsersController(ExampleClass exampleClass)
        {
     
        }
        //api/users/1
        [HttpGet]
        public IActionResult GetByid(int id)
        {
            return Ok();
        }

        //api/users
       [HttpPost]
       public IActionResult Post([FromBody] CreateUserModel createUser)
        {
            return CreatedAtAction(nameof(GetByid), new {id = 1}, createUser);
        }

        //api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id,[FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
