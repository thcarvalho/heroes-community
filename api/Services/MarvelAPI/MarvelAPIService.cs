using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace api.Services.MarvelAPI
{
  public class MarvelAPIService : IMarvelAPIService
  {
    private readonly IConfiguration _configuration;

    public MarvelAPIService(IConfiguration configuration)
    {
      _configuration = configuration;
    }
    public async Task<MarvelAPIResponse> GetData(string originalName)
    {
      string apikey = _configuration["Heroes:PublicAPI"];
      string hash = _configuration["Heroes:PrivateKey"];

      string baseURL = $"https://gateway.marvel.com/v1/public/characters?ts=1&apikey={apikey}&hash={hash}&name={originalName}";
      HttpClient client = new HttpClient();

      var res = client.GetStreamAsync(baseURL);
      var content = await JsonSerializer.DeserializeAsync<MarvelAPIResponse>(await res);

      return content;
    }
  }
}