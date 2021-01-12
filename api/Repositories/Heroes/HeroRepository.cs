using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories.Heroes
{
  public class HeroRepository : IHeroRepository
  {
    private readonly DataContext _context;

    public HeroRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<ActionResult<List<Hero>>> List()
    {
      var heroes = await _context.Heroes.Include(x => x.Images).Include(x => x.UserHeroes).ToListAsync();
      return heroes;
    }

    public async Task<ActionResult<Hero>> Read(int id)
    {
      var hero = await _context.Heroes.Include(x => x.Images).Include(x => x.UserHeroes).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
      return hero;
    }

    public async Task<ActionResult<Hero>> Save(Hero hero)
    {
      var verifyHero = await _context.Heroes.Where(x => x.OriginalName == hero.OriginalName).FirstOrDefaultAsync();
      if (verifyHero != null)
      {
        return verifyHero;
      }
      _context.Heroes.Add(hero);
      await _context.SaveChangesAsync();

      return await _context.Heroes.AsNoTracking().FirstOrDefaultAsync(x => x.Name == hero.Name);
    }
  }
}