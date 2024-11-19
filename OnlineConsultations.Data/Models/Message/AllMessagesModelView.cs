using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineConsultations.Data.DataConstants.DataConstants.MessageConstants;

namespace OnlineConsultations.Data.Models.Message
{
    public class AllMessagesModelView
    {
        [Key]
        [Required]
        public int MessageId { get; set; }

        [Required]
        [StringLength(MessageDescriptionMaxLength, MinimumLength = MessageDescriptionMinLength)]
        public required string MessageDescription { get; set; }

        public int ProvideUserId { get; set; }

        [ForeignKey(nameof(ProvideUserId))]
        public Entities.ProvideUser? ProvideUser { get; set; }

        public int SearchUserId { get; set; }

        [ForeignKey(nameof(SearchUserId))]
        public Entities.SearchUser? SearchUser { get; set; }

    }
}
