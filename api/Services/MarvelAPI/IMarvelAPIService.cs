using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace api.Services.MarvelAPI
{
  public interface IMarvelAPIService
  {
    Task<MarvelAPIResponse> GetData(string originalName);
  }
}