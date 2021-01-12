using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories.Likes
{
  public class LikeRepository : ILikeRepository
  {
    private readonly DataContext _context;

    public LikeRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<ActionResult<List<Like>>> ListByUser(int id)
    {
      var likes = await _context.Likes.Where(x => x.UserId == id).ToListAsync();
      return likes;
    }

    public async Task Save(Like like)
    {
      var verify = await _context.Likes.Where(x => x.UserId == like.UserId && x.LikedUser == like.LikedUser).FirstOrDefaultAsync();
      if (verify != null)
      {
        return;
      }
      _context.Likes.Add(like);
      await _context.SaveChangesAsync();
    }
  }
}