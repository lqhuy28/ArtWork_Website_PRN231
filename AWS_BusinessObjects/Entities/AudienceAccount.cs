using AWS_BusinessObjects.Common;
using AWS_BusinessObjects.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Entities
{
    public class AudienceAccount : BaseAuditableEntity
    {
        [ForeignKey("ApplicationUser")]
        public string UserAccountId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
