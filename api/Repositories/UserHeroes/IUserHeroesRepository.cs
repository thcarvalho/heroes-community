using System.Threading.Tasks;

namespace api.Repositories.UserHeroes
{
  public interface IUserHeroesRepository
  {
    Task Save(api.Models.UserHeroes userHeroes);
  }
}