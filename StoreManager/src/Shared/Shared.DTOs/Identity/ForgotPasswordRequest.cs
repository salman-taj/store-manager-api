using System.ComponentModel.DataAnnotations;

namespace StoreManager.Shared.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}