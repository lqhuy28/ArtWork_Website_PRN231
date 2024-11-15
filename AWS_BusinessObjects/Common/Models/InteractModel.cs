using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Models
{
    public class InteractModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "UserAccountId is required")]
        public string UserAccountId { get; set; }
        [Required(ErrorMessage = "ArtWorkID is required")]

        public Guid ArtWorkID { get; set; }

        [Required(ErrorMessage = "Comment is required")]
        public string Comment { get; set; }
        public bool? IsLike { get; set; }
    }
}
