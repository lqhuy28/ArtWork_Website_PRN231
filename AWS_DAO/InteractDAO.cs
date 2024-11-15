using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class InteractDAO
    {
        private readonly IApplicationDbContext _context;
        public InteractDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        // get all Interact, check isDeleted = false, sort by Created
        public List<Interact> GetAll()
        {
            try
            {
                List<Interact> interacts
                    = (List<Interact>)_context.Get<Interact>().Where(x => x.IsDeleted==false).OrderByDescending(x => x.Created) 
                    .ToList();
                return interacts;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Interact by id
        public Interact GetById(Guid id)
        {
            try
            {
                return _context.Get<Interact>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Interact
        public void Add(InteractModel interactModel)
        {
            try
            {
                Interact interact = new Interact();
                interact.Id = new Guid();
                interact.UserAccountId = interactModel.UserAccountId;
                interact.ArtWorkID = interactModel.ArtWorkID;
                interact.Comment = interactModel.Comment;
                interact.IsLike = interactModel.IsLike;
                interact.IsDeleted = false;
                interact.Created = DateTime.Now;
                _context.Get<Interact>().Add(interact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Interact
        public void Update(InteractModel interactModel)
        {
            try
            {
                var interact = _context.Get<Interact>().FirstOrDefault(x => x.Id == interactModel.Id);
                if (interact == null)
                {
                    throw new NotFoundException();
                }
                interact.ArtWorkID = interactModel.ArtWorkID;
                interact.Comment = interactModel.Comment;
                interact.IsLike = interactModel.IsLike;
                interact.LastModified = DateTime.Now;

                _context.Get<Interact>().Update(interact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Interact, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                var interact = _context.Get<Interact>().FirstOrDefault(x => x.Id == id);
                if (interact == null)
                {
                    throw new NotFoundException();
                }
                interact.IsDeleted = true;
                _context.Get<Interact>().Update(interact);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
