using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IInteractService
    {
        public List<Interact> GetAll();
        public Interact GetById(Guid id);
        public void Add(InteractModel interactModel);
        public void Update(InteractModel interactModel);
        public void Delete(Guid id);
    }
}
