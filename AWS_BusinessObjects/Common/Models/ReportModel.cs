using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Models
{
    public class ReportModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "UserAccountID is required")]
        public string UserAccountID { get; set; }
        [Required(ErrorMessage = "UserAccountIDReport is required")]
        public string UserAccountIDReport { get; set; }
        [Required(AllowEmptyStrings = true, ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description must be at most 500 characters")]
        public string? Description { get; set; }
    }
}
