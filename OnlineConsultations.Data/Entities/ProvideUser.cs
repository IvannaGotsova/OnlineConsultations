using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Entities
{
    public class ProvideUser 
    {
        [Required]
        public int ProvideUserId { get; set; }

        [Required]
        public required string ApplicationUserId { get; set; } 

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }

        public IEnumerable<Post> Posts = new List<Post>();

        public IEnumerable<Answer> Answers = new List<Answer>();

        public IEnumerable<Message> Messages = new List<Message>();
    }
}
