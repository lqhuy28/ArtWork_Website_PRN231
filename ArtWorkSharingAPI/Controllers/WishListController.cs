using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/wishlists")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        private readonly IWishListService _wishListService;

        public WishListController(IWishListService wishListService)
        {
            _wishListService = wishListService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var wishLists = _wishListService.GetAll();
            return Ok(wishLists);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var wishList = _wishListService.GetById(id);
            if (wishList == null)
            {
                return NotFound($"Không tìm thấy tranh mong muốn của bạn!, Id: {id}");
            }
            return Ok(wishList);
        }

        [HttpPost]
        public IActionResult Add(WistListModel wishListModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _wishListService.Add(wishListModel);
            return Ok("Thêm thành công");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var wishListCheck = _wishListService.GetById(id);
            if (wishListCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy tranh mong muốn của bạn!, Id: {id}");
                return NotFound(ModelState);
            }
            _wishListService.Delete(id);
            return Ok("Xóa thành công");
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, WistListModel wishListModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var wishListCheck = _wishListService.GetById(id);
            if (wishListCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy tranh mong muốn của bạn!, Id: {wishListModel.Id}");
                return NotFound(ModelState);
            }

            _wishListService.Update(wishListModel);
            return Ok("Cập nhật thành công");
        }
    }
}
