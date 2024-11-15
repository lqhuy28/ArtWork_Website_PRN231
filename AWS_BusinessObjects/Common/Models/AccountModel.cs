using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Common.Models
{
    public class AccountModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool isAdminAccount { get; set; }
        public bool isAudienceAccount { get; set; }
        public bool isArtistAccount { get; set; }
    }
}
