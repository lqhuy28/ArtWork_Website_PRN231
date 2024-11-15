using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Enums;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _orderService.GetAll();
            return Ok(orders);
        }

        [HttpGet("status/{status}")]
        public IActionResult GetByStatus(OrderStatus status)
        {
            var orders = _orderService.GetAll().Where(o => o.Status == status);
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var order = _orderService.GetById(id);
            if (order == null)
            {
                return NotFound($"Không tìm thấy đơn đặt hàng của bạn!, Id: {id}");
            }
            return Ok(order);
        }

        [HttpPost]
        public IActionResult Add(OrderModel orderModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _orderService.Add(orderModel);
            return Ok("Thêm thành công");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var orderCheck = _orderService.GetById(id);
            if (orderCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy đơn đặt hàng của bạn!, Id: {id}");
                return NotFound(ModelState);
            }
            _orderService.Delete(id);
            return Ok("Xóa thành công");
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, OrderModel orderModel)
        {
            var orderCheck = _orderService.GetById(id);
            if (orderCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy đơn đặt hàng của bạn!, Id: {orderModel.Id}");
                return NotFound(ModelState);
            }
            _orderService.Update(orderModel);
            return Ok("Cập nhật thành công");
        }

        [HttpPut("artwork/{artworkId}/status/cancel")]
        public IActionResult UpdateStatusToCancel(Guid artworkId)
        {
            var ordersToUpdate = _orderService.GetAll().Where(o => o.ArtWorkID == artworkId && o.Status != OrderStatus.Accepted).ToList();
            if (!ordersToUpdate.Any())
            {
                return NotFound($"Không tìm thấy đơn đặt hàng nào để cập nhật, ArtWorkID: {artworkId}");
            }

            foreach (var order in ordersToUpdate)
            {
                order.Status = OrderStatus.Cancelled;

                var orderModel = new OrderModel
                {
                    Id = order.Id,
                    Status = order.Status,
                    ArtWorkID = order.ArtWorkID,
                    BuyerAccountId = order.BuyerAccountId,
                    OwnerAccountId = order.OwnerAccountId
                };

                _orderService.Update(orderModel);
            }
            return Ok("Cập nhật trạng thái hủy thành công cho tất cả các đơn đặt hàng liên quan");
        }
    }
}
