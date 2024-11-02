using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Entities
{
    internal class Question
    {
        [Required]
        public int QuestionId { get; set; }

        [Required]
        public string? QuestionTitle { get; set; }

        [Required]
        public string? QuestionDescription { get; set; }

        [Required]
        public DateTime QuestionDate { get; set; }

        [Required]
        public int GuestUserId { get; set; }

        [ForeignKey(nameof(GuestUserId))]
        public GuestUser GuestUser { get; set; } = null!;

        [Required]
        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public SearchUser SearchUser { get; set; } = null!;

        public IEnumerable<Answer> Answers = new List<Answer>();
    }
}
