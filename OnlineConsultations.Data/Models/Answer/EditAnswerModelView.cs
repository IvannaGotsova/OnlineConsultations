using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.AnswerConstants;

namespace OnlineConsultations.Data.Models.Answer
{
    public class EditAnswerModelView
    {
        [Key]
        [Required]
        public int AnswerId { get; set; }

        [Required]
        [StringLength(AnswerDescriptionMaxLength, MinimumLength = AnswerDescriptionMinLength)]
        public required string AnswerDescription { get; set; }

        [Required]
        public DateTime AnswerDate { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public Entities.ProvideUser? ProvideUser { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public Entities.Question? Question { get; set; }
    }
}
