using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.CommentConstants;

namespace OnlineConsultations.Data.Models.Comment
{
    public class AddCommentModelView
    {
        [Required]
        [StringLength(CommentTitleMaxLength, MinimumLength = CommentTitleMinLength)]
        public string CommentTitle { get; set; }

        [Required]
        [StringLength(CommentDescriptionMaxLength, MinimumLength = CommentDescriptionMinLength)]
        public string CommentDescription { get; set; }

        public int? GuestUserId { get; set; } = null;

        [ForeignKey(nameof(GuestUserId))]
        public Entities.GuestUser? GuestUser { get; set; }

        public int? SearchUserId { get; set; } = null;

        [ForeignKey(nameof(SearchUserId))]
        public Entities.SearchUser? SearchUser { get; set; }

        [Required]
        public int AnswerId { get; set; }

        [ForeignKey(nameof(AnswerId))]
        public Entities.Answer? Answer { get; set; }
    }
}
