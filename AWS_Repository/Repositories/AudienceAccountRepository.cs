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
    public class AudienceAccountRepository : IAudienceAccountRepository
    {
        private readonly AudienceAccountDAO _audienceAccountDAO;
        public AudienceAccountRepository(AudienceAccountDAO audienceAccountDAO)
        {
            _audienceAccountDAO = audienceAccountDAO;
        }
        public void Add(AudienceAccount audienceAccount)
        => _audienceAccountDAO.Add(audienceAccount);

        public void Delete(AudienceAccount audienceAccount)
        => _audienceAccountDAO.Delete(audienceAccount);

        public List<AudienceAccount> GetAll()
        => _audienceAccountDAO.GetAll();

        public AudienceAccount GetById(Guid id)
        => _audienceAccountDAO.GetById(id);

        public void Update(AudienceAccount audienceAccount)
        => _audienceAccountDAO.Update(audienceAccount);
    }
}
