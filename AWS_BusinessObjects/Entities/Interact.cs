using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class Interact : BaseAuditableEntity
    {
        [ForeignKey(nameof(ArtWork))]
        [Required(ErrorMessage = "ArtWordID is required")]
        public Guid ArtWorkID { get; set; }

        // bị vòng

        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }

        [Required(ErrorMessage = "Comment is required")]
        public string Comment { get; set; }
        public bool? IsLike { get; set; }

    }
}
