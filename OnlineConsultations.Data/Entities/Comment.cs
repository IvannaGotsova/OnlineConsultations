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
        public string? CommentTitle { get; set; }

        [Required]
        [StringLength(CommentDescriptionMaxLength)]
        public string? CommentDescription { get; set; }

        [Required]
        public int GuestUserId { get; set; }

        [ForeignKey(nameof(GuestUserId))]
        public GuestUser GuestUser { get; set; } = null!;

        [Required]
        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public SearchUser SearchUser { get; set; } = null!;

        public Answer? Answer { get; set; }
    }
}
