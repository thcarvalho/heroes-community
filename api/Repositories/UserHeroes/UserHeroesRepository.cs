using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories.UserHeroes
{
  public class UserHeroesRepository : IUserHeroesRepository
  {
    private readonly DataContext _context;

    public UserHeroesRepository(DataContext context)
    {
      _context = context;
    }

    public async Task Save(Models.UserHeroes userHeroes)
    {
      var verify = await _context.UserHeroes.Where(x => x.UserId == userHeroes.UserId && x.HeroId == userHeroes.HeroId).FirstOrDefaultAsync();
      if (verify != null)
      {
        return;
      }
      _context.UserHeroes.Add(userHeroes);
      await _context.SaveChangesAsync();
    }
  }
}