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
    internal class Post
    {
        [Key]
        [Required]
        public int PostId { get; set; }

        [Required]
        [StringLength(PostTitleMaxLength)]
        public required string PostTitle { get; set; }

        [Required]
        [StringLength(PostDescriptionMaxLength)]
        public required string PostDescription { get; set; }

        [Required]
        public required decimal PostPayPerDay { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public required ProvideUser ProvideUser { get; set; }
    }
}
