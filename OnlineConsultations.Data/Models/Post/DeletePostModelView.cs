using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.PostConstants;

namespace OnlineConsultations.Data.Models.Post
{
    public class DeletePostModelView
    {
        [Key]
        [Required]
        public int PostId { get; set; }

        [Required]
        [StringLength(PostTitleMaxLength, MinimumLength = PostTitleMinLength)]
        public required string PostTitle { get; set; }

        [Required]
        [StringLength(PostDescriptionMaxLength, MinimumLength = PostDescriptionMinLength)]
        public required string PostDescription { get; set; }

        [Required]
        [Range(typeof(double), "0.00", "10000.00", ConvertValueInInvariantCulture = true)]
        public decimal PostPayPerHour { get; set; }

        [Required]
        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public Entities.ProvideUser? ProvideUser { get; set; }
    }
}
