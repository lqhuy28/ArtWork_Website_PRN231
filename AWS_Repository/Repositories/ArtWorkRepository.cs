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
    public class ArtWorkRepository : IArtWorkRepository
    {
        private readonly ArtWorkDAO _artWorkDAO;
        public ArtWorkRepository(ArtWorkDAO artWorkDAO)
        {
            _artWorkDAO = artWorkDAO;
        }
        public void Add(ArtWorkModel artWork)
        {
            _artWorkDAO.Add(artWork);
            //throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            _artWorkDAO.Delete(id);
            //throw new NotImplementedException();
        }

        public List<ArtWork> GetAll()
        {
            return _artWorkDAO.GetAll();
            throw new NotImplementedException();
        }

        public ArtWork GetById(Guid id)
        {
            return _artWorkDAO.GetById(id);
            throw new NotImplementedException();
        }

        public void Update(ArtWork artWork)
        {
            _artWorkDAO.Update(artWork);
            //throw new NotImplementedException();
        }
    }
}
