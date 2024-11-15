using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Repository.Interface
{
    public interface IArtWorkRepository
    {
        public List<ArtWork> GetAll();
        public ArtWork GetById(Guid id);
        public void Add(ArtWorkModel artWork);
        public void Update(ArtWork artWork);
        public void Delete(Guid id);
    }
}

