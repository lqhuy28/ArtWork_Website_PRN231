using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
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
    public class InteractRepository : IInteractRepository
    {
        private readonly InteractDAO _interactDAO;
        public InteractRepository(InteractDAO interactDAO)
        {
            _interactDAO = interactDAO;
        }

        public void Add(InteractModel interactModel)
        => _interactDAO.Add(interactModel);

        public void Delete(Guid id)
        => _interactDAO.Delete(id);

        public List<Interact> GetAll()
        => _interactDAO.GetAll();

        public Interact GetById(Guid id)
        => _interactDAO.GetById(id);

        public void Update(InteractModel interactModel)
        => _interactDAO.Update(interactModel);    
    }
}
