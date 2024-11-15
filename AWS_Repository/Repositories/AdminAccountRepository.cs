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
    public class AdminAccountRepository : IAdminAccountRepository
    {
        private readonly AdminAccountDAO _adminAccountDAO;
        public AdminAccountRepository(AdminAccountDAO adminAccountDAO)
        {
            _adminAccountDAO = adminAccountDAO;
        }

        public void Add(AdminAccount adminAccount)
        => _adminAccountDAO.Add(adminAccount);

        public void Delete(AdminAccount adminAccount)
        => _adminAccountDAO.Delete(adminAccount);

        public List<AdminAccount> GetAll()
        => _adminAccountDAO.GetAll();

        public AdminAccount GetById(Guid id)
        => _adminAccountDAO.GetById(id);

        public void Update(AdminAccount adminAccount)
        => _adminAccountDAO.Update(adminAccount);
    }
}
