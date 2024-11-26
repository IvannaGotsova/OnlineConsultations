using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.QuestionConstants;

namespace OnlineConsultations.Data.Models.Question
{
    public class AddQuestionModelView
    {
        [Required]
        [StringLength(QuestionTitleMaxLength, MinimumLength = QuestionTitleMinLength)]
        public string QuestionTitle { get; set; }

        [Required]
        [StringLength(QuestionDescriptionMaxLength, MinimumLength = QuestionDescriptionMinLength)]
        public string QuestionDescription { get; set; }

        [Required]
        public DateTime QuestionDate { get; set; }

        public int? GuestUserId { get; set; } = null;

        [ForeignKey(nameof(GuestUserId))]
        public Entities.GuestUser? GuestUser { get; set; }

        public int? SearchUserId { get; set; } = null;

        [ForeignKey(nameof(SearchUserId))]
        public Entities.SearchUser? SearchUser { get; set; }

        public IEnumerable<Entities.Answer> Answers = new List<Entities.Answer>();
    }
}
