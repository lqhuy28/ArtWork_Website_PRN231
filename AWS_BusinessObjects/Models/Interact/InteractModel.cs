using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Models.Interact
{
    public class InteractModel
    {
        public Guid ArtWorkID { get; set; }
        public string UserAccountId { get; set; }
        public string Comment { get; set; }
        public bool? IsLike { get; set; }
    }
}
