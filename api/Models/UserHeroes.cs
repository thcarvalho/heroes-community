using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
  public class UserHeroes
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    // public User User { get; set; }

    [ForeignKey("Hero")]
    public int HeroId { get; set; }
    // public Hero Hero { get; set; }
  }
}