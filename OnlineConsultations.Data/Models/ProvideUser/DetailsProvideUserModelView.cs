using OnlineConsultations.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineConsultations.Data.Models.ProvideUser
{
    public class DetailsProvideUserModelView
    {
        [Key]
        [Required]
        public int ProvideUserId { get; set; }

        [Required]
        public required string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser? ApplicationUser { get; set; }

        public IEnumerable<Entities.Post> Posts = new List<Entities.Post>();

        public IEnumerable<Entities.Answer> Answers = new List<Entities.Answer>();

        public IEnumerable<Entities.Message> Messages = new List<Entities.Message>();
    }
}
