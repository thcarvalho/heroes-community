using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using api.Repositories.Heroes;
using api.Repositories.Images;
using api.Services.MarvelAPI;
using api.Services.TranslationAPI;
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
      [FromServices] IImageRepository imageRepository,
      [FromServices] DataContext context,
      [FromServices] IMarvelAPIService marvelAPI,
      [FromServices] ITranslationService translationService,
      [FromBody] Hero hero
    )
    {
      if (ModelState.IsValid)
      {
        try
        {
          var response = await marvelAPI.GetData(hero.OriginalName);

          hero.Bio = translationService.TranslateText(response.data.results[0].description).TranslatedText;

          var heroImg = response.data.results[0].thumbnail;
          Image img = new Image();

          ActionResult<Hero> res = await heroRepository.Save(hero);
          
          img.HeroId = res.Value.Id;
          img.Url = $"{heroImg.path}.{heroImg.extension}";

          await imageRepository.Save(img);

          return hero;
        }
        catch (ArgumentOutOfRangeException exception)
        {
          throw exception;
        }

      }
      return BadRequest(ModelState);
    }
  }
}