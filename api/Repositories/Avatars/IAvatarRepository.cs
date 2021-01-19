using System.Threading.Tasks;
using api.Models;

namespace api.Repositories.Avatars
{
  public interface IAvatarRepository
  {
    Task Save(Avatar avatar);
  }
}