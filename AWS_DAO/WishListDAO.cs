using AWS_BusinessObjects.Common.Interfaces;
using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_DAO.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_DAO
{
    public class WishListDAO
    {
        private readonly IApplicationDbContext _context;
        public WishListDAO(IApplicationDbContext context)
        {
            _context = context;
        }


        // get all Order
        public List<WishList> GetAll()
        {
            try
            {
                List<WishList> wishLists
                    = (List<WishList>)_context.Get<WishList>()
                    
                    .ToList();
                return wishLists;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Order by id
        public WishList GetById(Guid id)
        {
            try
            {
                return _context.Get<WishList>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Order
        public void Add(WistListModel wishListModel)
        {
            try
            {
                WishList wishList = new WishList();
                wishList.Id = new Guid();
                wishList.ArtWorkID = wishListModel.ArtWorkID;
                wishList.UserAccountId = wishListModel.UserAccountId;
                wishList.Created = DateTime.Now;
                wishList.IsDeleted = false;
                _context.Get<WishList>().Add(wishList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Order
        public void Update(WistListModel wishListModel)
        {
            try
            {
                var wishList = _context.Get<WishList>().FirstOrDefault(x => x.Id == wishListModel.Id);
                if (wishList == null)
                {
                    throw new NotFoundException();
                }
                wishList.ArtWorkID = wishListModel.ArtWorkID;
                wishList.UserAccountId = wishListModel.UserAccountId;
                wishList.LastModified = DateTime.Now;


                _context.Get<WishList>().Update(wishList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // delete Order, isDeleted = true
        public void Delete(Guid id)
        {
            try
            {
                WishList wishList = GetById(id);
                wishList.IsDeleted = true;
                _context.Get<WishList>().Update(wishList);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
