using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Entities
{
    internal class Comment
    {
        [Required]
        public int CommentId { get; set; }

        [Required]
        public string? CommentTitle { get; set; }

        [Required]
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
