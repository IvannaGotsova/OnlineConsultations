using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Models.SearchUser
{
    public class AllSearchUsersModelView
    {
        [Key]
        [Required]
        public int SearchUserId { get; set; }

        [Required]
        public required string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }

        public IEnumerable<Entities.Question> Questions = new List<Entities.Question>();

        public IEnumerable<Entities.Review> Reviews = new List<Entities.Review>();

        public IEnumerable<Entities.Rating> Ratings = new List<Entities.Rating>();

        public IEnumerable<Entities.Comment> Comments = new List<Entities.
            Comment>();

        public IEnumerable<Entities.Message> Messages = new List<Entities.Message>();
    }
}
