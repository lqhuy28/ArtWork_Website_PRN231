using AWS_BusinessObjects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Models
{
    public class ArtWorkModel
    {
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        [Required(ErrorMessage = "UserOwnerId is required")]
        public string UserOwnerId { get; set; }
        [Required(ErrorMessage = "Category required")]
        public Guid CategoryId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [RegularExpression(@"^[^\d]{0,50}$", ErrorMessage = "Name can have a maximum of 50 characters and should not contain numbers.")]
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
    }
}
