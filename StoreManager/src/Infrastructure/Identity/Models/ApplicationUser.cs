using Microsoft.AspNetCore.Identity;
using StoreManager.Domain.Contracts;

namespace StoreManager.Infrastructure.Identity.Models
{
    public class ApplicationUser : IdentityUser, IIdentityTenant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public string Tenant { get; set; }
    }
}