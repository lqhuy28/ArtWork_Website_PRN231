using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_BusinessObjects.Models.Artwork
{
    public class UpdateStatusArtwork
    {
        public Guid ArtworkId { get; set; }
        public int Status { get; set; }
    }
}
