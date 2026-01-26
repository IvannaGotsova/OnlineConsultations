using System.ComponentModel.DataAnnotations;
using static OnlineConsultations.Data.DataConstants.DataConstants.ApplicationUserConstants;

namespace SmoothieShop.Data.Models.ApplicationUserModels
{
    public class AddApplicationUserModel
    {
        [Required]
        [StringLength(UserMaxLengthUsername, MinimumLength = UserMinLengthUsername)]
        public string UserName { get; set; } = null!;
        [Required]
        [StringLength(UserMaxLengthFirstName, MinimumLength = UserMinLengthFirstName)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(UserMaxLengthLastName, MinimumLength = UserMinLengthLastName)]
        public string? LastName { get; set; }
    }
}
