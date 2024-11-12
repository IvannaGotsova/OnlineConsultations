using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static OnlineConsultations.Data.DataConstants.DataConstants.ApplicationUserConstants;

namespace OnlineConsultations.Data.Models.ApplicationUserModels
{
    public class ApplicationUserModelView
    {
        public string Id { get; set; } = null!;
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
