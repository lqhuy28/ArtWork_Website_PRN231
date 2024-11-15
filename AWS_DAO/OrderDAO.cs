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
    public class OrderDAO
    {
        private readonly IApplicationDbContext _context;
        public OrderDAO(IApplicationDbContext context)
        {
            _context = context;
        }

  
        // get all Order, check isDeleted = false, sort by Created
        public List<Order> GetAll()
        {
            try
            {
                List<Order> orders
                    = (List<Order>)_context.Get<Order>().Where(x => x.IsDeleted == false).OrderByDescending(x => x.Created)
                    .Include(o=>o.ArtWork)
                    .ToList();
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // get Order by id
        public Order GetById(Guid id)
        {
            try
            {
                return _context.Get<Order>().Where(o => o.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // add Order
        public void Add(OrderModel orderModel)
        {
            try
            {
                Order order = new Order();
                order.Id = new Guid();
                order.BuyerAccountId = orderModel.BuyerAccountId;
                order.OwnerAccountId = orderModel.OwnerAccountId;
                order.ArtWorkID = orderModel.ArtWorkID;
                order.Status = orderModel.Status;
                order.IsDeleted = false;
                order.Created = DateTime.Now;
                _context.Get<Order>().Add(order);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // update Order
        public void Update(OrderModel orderModel)
        {
            try
            {
                var order = _context.Get<Order>().FirstOrDefault(x => x.Id == orderModel.Id);
                if (order == null)
                {
                    throw new NotFoundException();
                }
                order.BuyerAccountId = orderModel.BuyerAccountId;
                order.OwnerAccountId = orderModel.OwnerAccountId;
                order.ArtWorkID = orderModel.ArtWorkID;
                order.Status = orderModel.Status;
                order.LastModified = DateTime.Now;

                _context.Get<Order>().Update(order);
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
                Order order = GetById(id);
                order.IsDeleted = true;
                _context.Get<Order>().Update(order);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
