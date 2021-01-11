using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using api.Repositories.Likes;
using api.Data;

namespace api.Controllers
{
  [Route("v1/likes")]
  [ApiController]
  public class LikeController : ControllerBase
  {
    [HttpGet("{id}")]
    public async Task<ActionResult<List<Like>>> GetLikesByUser(
      [FromServices] ILikeRepository likeRepository,
      [FromServices] DataContext context,
      int id
    )
    {
      var like = await likeRepository.ListByUser(id);
      return like;
    }

    [HttpPost("")]
    public async Task<ActionResult<Like>> PostLike(
      [FromServices] ILikeRepository likeRepository,
      [FromServices] DataContext context,
      [FromBody] Like like
    )
    {
      if (ModelState.IsValid)
      {
        await likeRepository.Save(like);
        return like;
      }
      return BadRequest(ModelState);
    }
  }
}