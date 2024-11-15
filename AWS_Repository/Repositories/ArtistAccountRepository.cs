using AWS_BusinessObjects.Entities;
using AWS_DAO;
using AWS_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Repositories
{
    public class ArtistAccountRepository : IArtistAccountRepository
    {
        private readonly ArtistAccountDAO _artistAccountDAO;
        public ArtistAccountRepository(ArtistAccountDAO artistAccountDAO)
        {
            _artistAccountDAO = artistAccountDAO;
        }

        public void Add(ArtistAccount artistAccount)
        => _artistAccountDAO.Add(artistAccount);

        public void Delete(ArtistAccount artistAccount)
        => _artistAccountDAO.Delete(artistAccount);

        public List<ArtistAccount> GetAll()
        => _artistAccountDAO.GetAll();

        public ArtistAccount GetById(Guid id)
        => _artistAccountDAO.GetById(id);

        public void Update(ArtistAccount artistAccount)
        => _artistAccountDAO.Update(artistAccount);
    }
}
