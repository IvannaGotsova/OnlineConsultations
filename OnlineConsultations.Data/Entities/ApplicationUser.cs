using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static OnlineConsultations.Data.DataConstants.DataConstants.ApplicationUserConstants;

namespace OnlineConsultations.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(UserMaxLengthFirstName)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(UserMaxLengthLastName)]
        public string? LastName { get; set; } 
    }
}
