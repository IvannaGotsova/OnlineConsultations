﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.CommentConstants;

namespace OnlineConsultations.Data.Models.Comment
{
    public class AllCommentsModelView
    {
        [Key]
        [Required]
        public int CommentId { get; set; }
        [Required]
        [StringLength(CommentTitleMaxLength, MinimumLength = CommentTitleMinLength)]
        public required string CommentTitle { get; set; }

        [Required]
        [StringLength(CommentDescriptionMaxLength, MinimumLength = CommentDescriptionMinLength)]
        public required string CommentDescription { get; set; }

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
