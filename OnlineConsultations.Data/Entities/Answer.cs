using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.AnswerConstants;

namespace OnlineConsultations.Data.Entities
{
    internal class Answer
    {
        [Key]
        [Required]
        public int AnswerId { get; set; }

        [Required]
        [StringLength(AnswerDescriptionMaxLength)]
        public required string AnswerDescription{ get; set; }

        [Required]
        public DateTime AnswerDate { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public ProvideUser ProvideUser { get; set; } = null!;

        [Required]
        public int QuestionId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Question Question { get; set; } = null!;

        public IEnumerable<Comment> Comments = new List<Comment>();
    }
}
