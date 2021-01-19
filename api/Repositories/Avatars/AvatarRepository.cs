using System.Threading.Tasks;
using api.Data;
using api.Models;

namespace api.Repositories.Avatars
{
  public class AvatarRepository : IAvatarRepository
  {
    private readonly DataContext _context;

    public AvatarRepository(DataContext context)
    {
      _context = context;
    }

    public async Task Save(Avatar avatar)
    {
      _context.Avatars.Add(avatar);
      await _context.SaveChangesAsync();
    }
  }
}