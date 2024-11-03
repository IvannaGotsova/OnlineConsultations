﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.PostConstants;

namespace OnlineConsultations.Data.Entities
{
    public class Post
    {
        [Key]
        [Required]
        public int PostId { get; set; }

        [Required]
        [StringLength(PostTitleMaxLength)]
        public  string? PostTitle { get; set; }

        [Required]
        [StringLength(PostDescriptionMaxLength)]
        public  string? PostDescription { get; set; }

        [Required]
        public  decimal PostPayPerDay { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public ProvideUser? ProvideUser { get; set; }
    }
}