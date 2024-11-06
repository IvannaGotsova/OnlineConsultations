using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.QuestionConstants;

namespace OnlineConsultations.Data.Entities
{
    public class Question
    {
        [Key]
        [Required]
        public int QuestionId { get; set; }

        [Required]   
        [StringLength(QuestionTitleMaxLength)]
        public required string QuestionTitle { get; set; }

        [Required]
        [StringLength(QuestionDescriptionMaxLength)]
        public required string QuestionDescription { get; set; }

        [Required]
        public DateTime QuestionDate { get; set; }

        public int GuestUserId { get; set; }

        [ForeignKey(nameof(GuestUserId))]
        public GuestUser? GuestUser { get; set; }

        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public SearchUser? SearchUser { get; set; }

        public IEnumerable<Answer> Answers = new List<Answer>();
    }
}
