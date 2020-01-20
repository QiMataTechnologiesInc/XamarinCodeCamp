using System.ComponentModel.DataAnnotations;

namespace AtlantaCodeCampMobile.Models
{
  public class SponsorViewModel
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    [Required]
    public string Link { get; set; }
    [Required]
    public string SponsorLevel { get; set; }

    public bool Paid { get; set; }

  }
}
