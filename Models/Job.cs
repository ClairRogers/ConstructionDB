using System.ComponentModel.DataAnnotations;

namespace construction.Models
{
  public class Job
  {
    [Required]
    public string Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    [Range(1, 9999999)]
    public decimal Budget { get; set; }
  }
}