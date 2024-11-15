using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Persistence;
using AWS_DAO.Common.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Enums;

namespace AWS_DAO
{
    public class ArtWorkDAO
    {
        private readonly IApplicationDbContext _context;
        public ArtWorkDAO(IApplicationDbContext context)
        {
            _context = context;
        }

        // get ArtWork by id
        public AWS_BusinessObjects.Entities.ArtWork GetById(Guid id)
        {
            try
            {
                return _context.Get<ArtWork>()
                    .Include(i => i.Category)
                    .Include(i => i.Orders)
                    .Include(i => i.Interacts)
                    .Where(o=>o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get all ArtWork
        public List<AWS_BusinessObjects.Entities.ArtWork> GetAll()
        {
            try
            {
                List<AWS_BusinessObjects.Entities.ArtWork> artWorks
                    = (List<ArtWork>)_context.Get<ArtWork>()
                    .Where(o=>o.IsDeleted == false)
                    .Include(i => i.Category)
                    .Include(i => i.Orders)
                    .Include(i => i.Interacts)
                    .Where(x => x.IsDeleted == false)
                    .OrderByDescending(x => x.Created)
                    .ToList();
                return artWorks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }   

        // add ArtWork
        public void Add(ArtWorkModel artWorks)
        {
            try
            {
                AWS_BusinessObjects.Entities.ArtWork newArtWork = new ArtWork()
                {
                    Id = new Guid(),
                    UserAccountId = artWorks.UserAccountId,
                    UserOwnerId = artWorks.UserOwnerId,
                    CategoryId = artWorks.CategoryId,
                    Name = artWorks.Name,
                    Description = artWorks.Description,
                    Price = artWorks.Price,
                    ImageUrl = artWorks.ImageUrl,
                    ArtWorkStatus = artWorks.ArtWorkStatus,
                    Created = DateTime.Now,
                    IsDeleted = false
                };
                _context.Get<ArtWork>().Add(newArtWork);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update ArtWork
        public void Update(AWS_BusinessObjects.Entities.ArtWork artWorks)
        {
            try
            {      
                var ArtWork = _context.Get<ArtWork>().FirstOrDefault(x => x.Id == artWorks.Id);
                if(ArtWork == null)
                {
                    throw new NotFoundException();
                }
                //ArtWork = artWorks;
                ArtWork.ArtWorkStatus = artWorks.ArtWorkStatus;              
                ArtWork.Name = artWorks.Name;
                ArtWork.UserAccountId = artWorks.UserAccountId;
                ArtWork.Description = artWorks.Description;
                ArtWork.Price = artWorks.Price;
                ArtWork.ImageUrl = artWorks.ImageUrl;
                ArtWork.LastModified = DateTime.Now;
                ArtWork.Interacts = artWorks.Interacts;
                ArtWork.Orders = artWorks.Orders;

                _context.Get<ArtWork>().Update(ArtWork);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                    throw new Exception(ex.Message);
            }
        }

        // delete ArtWork
        public void Delete(Guid id)
        {
            try
            {
                var ArtWork = _context.Get<ArtWork>().FirstOrDefault(x => x.Id == id);
                if (ArtWork == null)
                {
                    throw new NotFoundException();
                }
                ArtWork.IsDeleted = true;
                _context.Get<ArtWork>().Update(ArtWork);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
