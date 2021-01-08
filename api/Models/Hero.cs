namespace api.Models
{
  public class Hero
  {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Bio { get; set; }
      public Image[] Images { get; set; }
  }
}