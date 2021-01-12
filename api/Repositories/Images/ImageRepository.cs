using System.Threading.Tasks;
using api.Data;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Repositories.Images
{
  public class ImageRepository : IImageRepository
  {
    private readonly DataContext _context;

    public ImageRepository(DataContext context)
    {
      _context = context;
    }

    public async Task Save(Image image)
    {
      _context.Images.Add(image);
      await _context.SaveChangesAsync();
    }
  }
}