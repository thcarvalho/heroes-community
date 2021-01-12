using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Repositories.Images
{
  public interface IImageRepository
  {
    Task Save(Image image);
  }
}