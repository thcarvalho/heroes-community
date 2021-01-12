using System.Threading.Tasks;
using api.Data;
using api.Models;
using api.Repositories.UserHeroes;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("/v1/userheroes")]
  public class UserHeroesController : ControllerBase
  {
    [HttpPost("")]
    public async Task<ActionResult<UserHeroes>> PostUserHeroes(
      [FromServices] IUserHeroesRepository userHeroesRepository,
      [FromServices] DataContext context,
      [FromBody] UserHeroes userHeroes
    )
    {
      if (ModelState.IsValid)
      {
        await userHeroesRepository.Save(userHeroes);
        return userHeroes;
      }
      return BadRequest(ModelState);
    }

  }
}