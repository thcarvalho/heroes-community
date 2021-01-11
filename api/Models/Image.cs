using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
  public class Image
  {
      [Key]
      public int Id { get; set; }
      [ForeignKey("Hero")]
      public int HeroId { get; set; }
      public string Url { get; set; }
  }
}