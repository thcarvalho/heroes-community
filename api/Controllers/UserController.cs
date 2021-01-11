using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using api.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("v1/users")]
  [ApiController]
  public class UserController : ControllerBase
  {
    [HttpGet("")]
    public async Task<ActionResult<List<User>>> GetUsers(
        [FromServices] DataContext context,
        [FromServices] IUserRepository userRepository
    )
    {
      var users = await userRepository.List();
      return users;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById(
        [FromServices] DataContext context,
        [FromServices] IUserRepository userRepository,
        int id
    )
    {
      var user = await userRepository.Read(id);
      return user;
    }

    [HttpPost("")]
    public async Task<ActionResult<User>> PostUser(
        [FromServices] IUserRepository userRepository,
        [FromServices] DataContext context,
        [FromBody] User user
    )
    {
      if (ModelState.IsValid)
      {
        await userRepository.Save(user);
        return user;
      }
      return BadRequest(ModelState);
    }
  }
}