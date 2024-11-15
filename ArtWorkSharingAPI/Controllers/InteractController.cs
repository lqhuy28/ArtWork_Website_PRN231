using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/interacts")]
    [ApiController]
    public class InteractController : ControllerBase
    {
        private readonly IInteractService _interactService;

        public InteractController(IInteractService interactService)
        {
            _interactService = interactService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var interacts = _interactService.GetAll();
            return Ok(interacts);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var interact = _interactService.GetById(id);
            if (interact == null)
            {
                return NotFound($"Không tìm thấy tương tác của bạn!, Id: {id}");
            }
            return Ok(interact);
        }

        [HttpPost]
        public IActionResult Add(InteractModel interactModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _interactService.Add(interactModel);
            return Ok("Thêm thành công");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var interactCheck = _interactService.GetById(id);
            if (interactCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy tương tác của bạn!, Id: {id}");
                return NotFound(ModelState);
            }
            _interactService.Delete(id);
            return Ok("Xóa thành công");
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, InteractModel interactModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var interactCheck = _interactService.GetById(id);
            if (interactCheck == null)
            {
                ModelState.AddModelError("Id", $"Không tìm thấy tương tác của bạn!, Id: {interactModel.Id}");
                return NotFound(ModelState);
            }

            _interactService.Update(interactModel);
            return Ok("Cập nhật thành công");
        }
    }
}
