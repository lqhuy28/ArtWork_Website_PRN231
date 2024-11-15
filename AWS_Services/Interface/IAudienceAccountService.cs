using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IAudienceAccountService
    {
        public List<AudienceAccount> GetAll();
        public AudienceAccount GetById(Guid id);
        public void Add(AudienceAccount audienceAccount);
        public void Update(AudienceAccount audienceAccount);
        public void Delete(AudienceAccount audienceAccount);
    }
}
