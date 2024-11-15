using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound($"Không tìm thấy loại tranh của bạn!, Id: {id}");
            }
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _categoryService.Add(category);
            return Ok("Thêm thành công");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var categoryCheck = _categoryService.GetById(id);
            if (categoryCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy loại tranh của bạn!, Id: {id}");
                return NotFound(ModelState);
            }
            _categoryService.Delete(id);
            return Ok("Xóa thành công");
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, CategoryModel categoryModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoryCheck = _categoryService.GetById(id);
            if (categoryCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy loại tranh của bạn!, Id: {id}");
                return NotFound(ModelState);
            }

            _categoryService.Update(categoryModel);
            return Ok("Cập nhật thành công");
        }
    }
}
