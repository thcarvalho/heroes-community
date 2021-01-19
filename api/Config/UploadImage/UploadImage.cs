using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace api.Config.UploadImage
{
  public class UploadImage : IUploadImage
  {
    private readonly IHostingEnvironment _webHostEnvironment;

    public UploadImage(IHostingEnvironment webHostEnvironment)
    {
      _webHostEnvironment = webHostEnvironment;
    }

    public async Task<string> Save(IFormFile file)
    {
      string fileName = DateTime.Now.Millisecond.ToString() + file.FileName;
      string webRoot = _webHostEnvironment.ContentRootPath;
      string path = Path.Combine(webRoot, "Uploads/Images/") + fileName;

      var stream = new FileStream(path, FileMode.Create);
      await file.CopyToAsync(stream);

      string url = $"https://localhost:5001/Uploads/Images/{fileName}";

      return url;
    }
  }
}