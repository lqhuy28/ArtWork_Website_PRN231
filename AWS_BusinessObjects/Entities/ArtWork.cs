using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Enums;
using AWS_BusinessObjects.Identity;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class ArtWork : BaseAuditableEntity
    {

        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        //public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("ApplicationUser")]
        [Required(ErrorMessage = "UserOwnerId is required")]
        public string UserOwnerId { get; set; }
        //public virtual ApplicationUser UserOwner { get; set; }

        [ForeignKey("Category")]        
        public Guid CategoryId { get; set; }
        


        [Required(ErrorMessage = "Art Work Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Za-z\s]{1,50}$", ErrorMessage = "Name can have a maximum of 50 characters and should not contain numbers or special characters.")]
        public string Name { get; set; }


        [Required(AllowEmptyStrings = true, ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description must be at most 500 characters")]
        public string Description { get; set; }


        [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10000")]
        public float Price { get; set; }


        [Required(ErrorMessage = "ImageUrl is required")]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }


        public ArtWorkStatus ArtWorkStatus { get; set; }

        public virtual IList<Order>? Orders { get; set; }

        public virtual IList<Interact>? Interacts { get; set; }

        public virtual IList<WishList>? WishLists { get; set; }

        public virtual Category? Category { get; set; }
    }
}
