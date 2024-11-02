using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Entities
{
    internal class SearchUser : ApplicationUser
    {
        [Required]
        public int SearchUserId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; } = null!;

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }

        public IEnumerable<Question> Questions = new List<Question>();

        public IEnumerable<Review> Reviews = new List<Review>();

        public IEnumerable<Rating> Ratings = new List<Rating>();

        public IEnumerable<Comment> Comments = new List<Comment>();

        public IEnumerable<Message> Messages = new List<Message>();
    }
}
