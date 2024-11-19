using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Models.GuestUser
{
    public class DeleteGuestUserModelView
    {
        [Key]
        [Required]
        public int GuestUserId { get; set; }

        [Required]
        public required string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }

        public IEnumerable<Entities.Question> Questions = new List<Entities.Question>();

        public IEnumerable<Entities.Comment> Comments = new List<Entities.Comment>();
    }
}
