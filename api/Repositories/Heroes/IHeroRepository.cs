using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Repositories.Heroes
{
  public interface IHeroRepository
  {
    Task Save(Hero hero);
    Task<ActionResult<List<Hero>>> List();
    Task<ActionResult<Hero>> Read(int id);
  }
}