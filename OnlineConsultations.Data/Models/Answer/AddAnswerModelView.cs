using System;
using System.Collections.Generic;
using OnlineConsultations.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.AnswerConstants;

namespace OnlineConsultations.Data.Models.Answer
{
    public class AddAnswerModelView
    {
        [Required]
        [StringLength(AnswerDescriptionMaxLength, MinimumLength = AnswerDescriptionMinLength)]
        public string AnswerDescription { get; set; }

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
