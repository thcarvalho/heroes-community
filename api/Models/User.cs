using System.ComponentModel.DataAnnotations;

namespace api.Models
{
  public class User
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Required field")]
    [MinLength(3, ErrorMessage = "Min length is 3 characters")]
    [MaxLength(60, ErrorMessage = "Max length is 60 characters")]
    public string Username { get; set; }

    public int[] Likes { get; set; }
    
    public Hero[] Heroes { get; set; }
  }
}