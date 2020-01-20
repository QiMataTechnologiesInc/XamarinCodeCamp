using System.ComponentModel.DataAnnotations;

namespace AtlantaCodeCampMobile.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
