using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class AudienceAccountService : IAudienceAccountService
    {
        private readonly IAudienceAccountRepository accountRepository;
        public AudienceAccountService(IAudienceAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Add(AudienceAccount audienceAccount)
        => accountRepository.Add(audienceAccount);

        public void Delete(AudienceAccount audienceAccount)
        => accountRepository.Delete(audienceAccount);

        public List<AudienceAccount> GetAll()
        => accountRepository.GetAll();

        public AudienceAccount GetById(Guid id)
        => accountRepository.GetById(id);

        public void Update(AudienceAccount audienceAccount)
        => accountRepository.Update(audienceAccount);
    }
}
