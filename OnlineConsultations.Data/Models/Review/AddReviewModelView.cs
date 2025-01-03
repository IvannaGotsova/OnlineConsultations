﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.ReviewConstants;

namespace OnlineConsultations.Data.Models.Review
{
    public class AddReviewModelView
    {
        [Required]
        [StringLength(ReviewDescriptionMaxLength, MinimumLength = ReviewDescriptionMinLength)]
        public string ReviewDescription { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public Entities.ProvideUser? ProvideUser { get; set; }

        [Required]
        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public Entities.SearchUser? SearchUser { get; set; }
    }
}
