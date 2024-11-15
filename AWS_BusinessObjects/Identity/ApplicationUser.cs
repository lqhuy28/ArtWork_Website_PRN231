using AWS_BusinessObjects.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Address { get; set; }

        public virtual IList<AdminAccount>? AdminAccounts { get; set; }
        public virtual IList<AudienceAccount>? AudienceAccounts { get; set; }
        public virtual IList<ArtistAccount>? ArtistAccounts { get; set; }
        public virtual IList<Interact>? Interacts { get; set; }
        public virtual IList<Report>? Reports { get; set; }  
        public virtual IList<ArtWork>? ArtWorks { get; set; }
        public virtual IList<Order>? Orders { get; set; }
        public virtual IList<WishList>? WishLists { get; set; }
    }
}
