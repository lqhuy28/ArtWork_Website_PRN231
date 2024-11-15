using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface IArtistAccountRepository
    {
        public List<ArtistAccount> GetAll();
        public ArtistAccount GetById(Guid id);
        public void Add(ArtistAccount artistAccount);
        public void Update(ArtistAccount artistAccount);
        public void Delete(ArtistAccount artistAccount);
    }
}
