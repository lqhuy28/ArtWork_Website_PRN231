using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
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
    public class Order : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "UserAccountId is required")]
        public string? BuyerAccountId { get; set; }

        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "OwnerAccountId is required")]
        public string? OwnerAccountId { get; set; }


        [ForeignKey(nameof(ArtWork))]
        [Required(ErrorMessage = "ArtWordID is required")]
        public Guid? ArtWorkID { get; set; }
        public virtual ArtWork? ArtWork { get; set; }

        public OrderStatus Status { get; set; }
    }
}
