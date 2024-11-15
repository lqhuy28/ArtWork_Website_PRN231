using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface IAdminAccountRepository
    {
        public List<AdminAccount> GetAll();
        public AdminAccount GetById(Guid id);
        public void Add(AdminAccount adminAccount);
        public void Update(AdminAccount adminAccount);
        public void Delete(AdminAccount adminAccount);
    }
}
