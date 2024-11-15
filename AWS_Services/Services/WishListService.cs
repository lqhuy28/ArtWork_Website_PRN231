using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Repository.Interface;
using AWS_Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Services
{
    public class WishListService : IWishListService
    {
        private readonly IWishListRepository wishListRepository;
        public WishListService(IWishListRepository wishListRepository)
        {
            this.wishListRepository = wishListRepository;
        }
        public void Add(WistListModel wishListModel) => wishListRepository.Add(wishListModel);
        public void Delete(Guid id) => wishListRepository.Delete(id);
        public List<WishList> GetAll() => wishListRepository.GetAll();
        public WishList GetById(Guid id) => wishListRepository.GetById(id);
        public void Update(WistListModel wishListModel) => wishListRepository.Update(wishListModel);
    }
}