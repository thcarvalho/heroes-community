using System;
using System.IO;
using System.Threading.Tasks;
using api.Config.UploadImage;
using api.Data;
using api.Models;
using api.Repositories.Avatars;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("v1/avatar")]
  [ApiController]
  public class AvatarController : ControllerBase
  {

    [HttpPost("")]
    public async Task<ActionResult<Avatar>> PostAvatar(
      [FromServices] DataContext context,
      [FromServices] IUploadImage upload,
      [FromServices] IAvatarRepository avatarRepository,
      [FromForm] IFormFile file,
      [FromForm] int userId
      )
    {
      string url = await upload.Save(file);
      Avatar avatar = new Avatar { Url=url, UserId=userId };
      await avatarRepository.Save(avatar);
      return avatar;
    }
  }
}