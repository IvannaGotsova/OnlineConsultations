using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.ReviewConstants;

namespace OnlineConsultations.Data.Entities
{
    internal class Review
    {
        [Key]
        [Required]
        public int ReviewId { get; set; }

        [Required]
        [StringLength(ReviewDescriptionMaxLength)]
        public string? ReviewDescription { get; set; }    

        [Required]
        public DateTime ReviewDate { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public ProvideUser ProvideUser { get; set; } = null!;

        [Required]
        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public SearchUser SearchUser { get; set; } = null!;
    }
}
