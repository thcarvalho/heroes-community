using System.Collections.Generic;

namespace api.Services.MarvelAPI
{
  public class MarvelAPIResponse
  {
    public Data data { get; set; }
  }

  public class Data
  {
    public List<Results> results { get; set; }
  }
  public class Results
  {
    public string name { get; set; }
    public string description { get; set; }
    public Thumbnail thumbnail { get; set; }
  }
  public class Thumbnail
  {
    public string path { get; set; }
    public string extension { get; set; }

  }
}