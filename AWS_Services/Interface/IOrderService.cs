using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWS_Services.Interface
{
    public interface IOrderService
    {
        public List<Order> GetAll();
        public Order GetById(Guid id);
        public void Add(OrderModel orderModel);
        public void Update(OrderModel orderModel);
        public void Delete(Guid id);
    }
}
