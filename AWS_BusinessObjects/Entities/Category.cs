using AWS_BusinessObjects.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace AWS_BusinessObjects.Entities
{
    public class Category : BaseAuditableEntity
    {
        [Required(ErrorMessage = "CategoryName is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
        [RegularExpression(@"^[A-Za-z0-9\s]{1,50}$", ErrorMessage = "Name can have a maximum of 50 characters and should not contain numbers or special characters.")]
        public string CategoryName { get; set; }
        [Required(AllowEmptyStrings = true, ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description must be at most 500 characters")]
        public string Description { get; set; }

        public virtual IList<ArtWork>? ArtWorks { get; set; }
    }
}
