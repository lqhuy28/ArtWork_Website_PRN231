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
    public class AdminAccountService : IAdminAccountService
    {
        private readonly IAdminAccountRepository accountRepository;
        public AdminAccountService(IAdminAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Add(AdminAccount adminAccount)
        => accountRepository.Add(adminAccount);

        public void Delete(AdminAccount adminAccount)
        => accountRepository.Delete(adminAccount);

        public List<AdminAccount> GetAll()
        => accountRepository.GetAll();

        public AdminAccount GetById(Guid id)
        => accountRepository.GetById(id);

        public void Update(AdminAccount adminAccount)
        => accountRepository.Update(adminAccount);
    }
}
