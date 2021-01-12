using System.Threading.Tasks;
using api.Data;

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
      _context.UserHeroes.Add(userHeroes);
      await _context.SaveChangesAsync();
    }
  }
}