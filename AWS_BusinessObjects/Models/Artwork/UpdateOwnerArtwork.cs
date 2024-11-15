using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Models.Artwork
{
    public class UpdateOwnerArtwork
    {
        public Guid ArtworkId { get; set; }
        public string UserOwnerId { get; set; }
    }
}
