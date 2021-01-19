using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace api.Config.UploadImage
{
  public interface IUploadImage
  {
    Task<string> Save(IFormFile file);
  }
}