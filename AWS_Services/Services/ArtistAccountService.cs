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
    public class ArtistAccountService : IArtistAccountService
    {
        private readonly IArtistAccountRepository accountRepository;
        public ArtistAccountService(IArtistAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Add(ArtistAccount artistAccount)
        => accountRepository.Add(artistAccount);

        public void Delete(ArtistAccount artistAccount)
        => accountRepository.Delete(artistAccount);

        public List<ArtistAccount> GetAll()
        => accountRepository.GetAll();

        public ArtistAccount GetById(Guid id)
        => accountRepository.GetById(id);

        public void Update(ArtistAccount artistAccount)
        => accountRepository.Update(artistAccount);
    }
}
