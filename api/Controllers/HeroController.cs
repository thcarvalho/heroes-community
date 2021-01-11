using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using api.Repositories.Heroes;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("v1/heroes")]
  [ApiController]
  public class HeroController : ControllerBase
  {
    [HttpGet("")]
    public async Task<ActionResult<List<Hero>>> GetHeroes(
      [FromServices] IHeroRepository heroRepository,
      [FromServices] DataContext context
    )
    {
      var heroes = await heroRepository.List();
      return heroes;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Hero>> GetHeroesById(
      [FromServices] IHeroRepository heroRepository,
      [FromServices] DataContext context,
      int id
    )
    {
      var hero = await heroRepository.Read(id);
      return hero;
    }

    [HttpPost("")]
    public async Task<ActionResult<Hero>> Post(
      [FromServices] IHeroRepository heroRepository,
      [FromServices] DataContext context,
      [FromBody] Hero hero
    )
    {
      if (ModelState.IsValid)
      {
        await heroRepository.Save(hero);
        return hero;
      }
      return BadRequest(ModelState);
    }
  }
}