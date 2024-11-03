using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Entities
{
    public class ProvideUser : ApplicationUser
    {
        [Key]
        [Required]
        public int ProvideUserId { get; set; }

        [Required]
        public string? ApplicationUserId { get; set; } 

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }

        [Required]
        public int PostId { get; set; }

        [ForeignKey(nameof(PostId))]
        public Post? Post { get; set; }

        public IEnumerable<Answer> Answers = new List<Answer>();

        public IEnumerable<Message> Messages = new List<Message>();
    }
}
