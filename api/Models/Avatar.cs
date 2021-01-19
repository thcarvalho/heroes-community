using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
  public class Avatar
  {
      [Key]
      public int Id { get; set; }
      [ForeignKey("User")]
      public int UserId { get; set; }
      public string Url { get; set; }
  }
}