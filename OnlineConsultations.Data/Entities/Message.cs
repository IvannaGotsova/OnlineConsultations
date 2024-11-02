using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.MessageConstants;

namespace OnlineConsultations.Data.Entities
{
    public class Message
    {
        [Key]
        [Required]
        public int MessageId { get; set; }

        [Required]
        [StringLength(MessageDescriptionMaxLength)]
        public string? MessageDescription { get; set; }

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
