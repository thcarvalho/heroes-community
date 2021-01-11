using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
  public class Hero
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Required field")]
    [MinLength(3, ErrorMessage = "Min length is 3 characters")]
    [MaxLength(60, ErrorMessage = "Max length is 60 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Required field")]
    [MinLength(3, ErrorMessage = "Min length is 3 characters")]
    [MaxLength(1000, ErrorMessage = "Max length is 1000 characters")]
    public string Bio { get; set; }
    public ICollection<Image> Images { get; set; }
  }
}