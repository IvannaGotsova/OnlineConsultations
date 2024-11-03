using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.RatingConstants;

namespace OnlineConsultations.Data.Entities
{
    public class Rating
    {
        [Key]
        [Required]
        public int RatingId { get; set; }

        [Required]
        public int RatingValue { get; set; }   

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public ProvideUser? ProvideUser { get; set; }

        [Required]
        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public SearchUser? SearchUser { get; set; } 
    }
}
