using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Repositories.Likes
{
  public interface ILikeRepository
  {
    Task Save(Like like);
    Task<ActionResult<List<Like>>> ListByUser(int id);
  }
}