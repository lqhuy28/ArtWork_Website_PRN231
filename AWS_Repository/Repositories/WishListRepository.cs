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
    public class WishListRepository : IWishListRepository
    {
        private readonly WishListDAO _wishListDAO;
        public WishListRepository(WishListDAO wishListDAO)
        {
            _wishListDAO = wishListDAO;
        }

        public void Add(WistListModel wishListModel) => _wishListDAO.Add(wishListModel);

        public void Delete(Guid id) => _wishListDAO.Delete(id);

        public List<WishList> GetAll() => _wishListDAO.GetAll();

        public WishList GetById(Guid id) => _wishListDAO.GetById(id);

        public void Update(WistListModel wishListModel) => _wishListDAO.Update(wishListModel);
    }
}
