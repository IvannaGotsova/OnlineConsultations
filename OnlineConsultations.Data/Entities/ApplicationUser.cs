using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.ApplicationUserConstants;

namespace OnlineConsultations.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(UserMaxLengthFirstName)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(UserMaxLengthLastName)]
        public string LastName { get; set; } = null!;
    }
}
