using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWS_BusinessObjects.Identity;

namespace AWS_BusinessObjects.Entities
{
    public class WishList : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        [ForeignKey("ArtWork")]
        [Required(ErrorMessage = "ArtWorkID is required")]
        public Guid ArtWorkID { get; set; }
        
    }
}
