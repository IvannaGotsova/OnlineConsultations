using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.CommentConstants;

namespace OnlineConsultations.Data.Entities
{
    public class Comment
    {
        [Key]
        [Required]
        public int CommentId { get; set; }

        [Required]
        [StringLength(CommentTitleMaxLength)]
        public required string CommentTitle { get; set; }

        [Required]
        [StringLength(CommentDescriptionMaxLength)]
        public required string CommentDescription { get; set; }

        public int GuestUserId { get; set; }

        [ForeignKey(nameof(GuestUserId))]
        public GuestUser? GuestUser { get; set; }

        public int SearchUserId { get; set; } 

        [ForeignKey(nameof(SearchUserId))]
        public SearchUser? SearchUser { get; set; } 

        [Required]
        public int AnswerId { get; set; }

        [ForeignKey(nameof(AnswerId))]
        public Answer? Answer { get; set; }
    }
}
