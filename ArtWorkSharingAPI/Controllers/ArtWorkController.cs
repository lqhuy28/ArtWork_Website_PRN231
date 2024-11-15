using AWS_BusinessObjects.Common.Models;
using AWS_BusinessObjects.Entities;
using AWS_BusinessObjects.Models.Artwork;
using AWS_Repository.Identity;
using AWS_Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/artworks")]
    [ApiController]
    public class ArtWorkController : ControllerBase
    {
        private readonly IArtWorkService _artWorkService;

        public ArtWorkController(IArtWorkService artWorkService)
        {
            _artWorkService = artWorkService;
        }

        //[Authorize(Roles = "1, 2, 3")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var artWorks = _artWorkService.GetAll();
            return Ok(artWorks);
        }

        //[Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var artWork = _artWorkService.GetById(id);
            if (artWork == null)
            {
                return NotFound($"Không tìm thấy tranh của bạn!, Id: {id}");
            }
            return Ok(artWork);
        }

        //[Authorize(Roles = "1, 2, 3")]
        [HttpPost]
        public IActionResult Add(ArtWorkModel artWork)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                _artWorkService.Add(artWork);
                return Ok("Thêm thành công");
            }
        }

        //[Authorize(Roles = "1, 2, 3")]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if (ModelState.IsValid)
            {
                var artWorkCheck = _artWorkService.GetById(id);
                if (artWorkCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tranh của bạn!, Id: {id}");
                    return NotFound(ModelState);
                }
                else
                {
                    _artWorkService.Delete(id);
                    return Ok("Xóa thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }

        //[Authorize(Roles = "1, 2, 3")]
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, ArtWork artWork)
        {
            if (ModelState.IsValid)
            {
                var artWorkCheck = _artWorkService.GetById(id);
                if (artWorkCheck == null)
                {
                    ModelState.AddModelError($"Id", $"Không tìm thấy tranh của bạn!, Id: {artWork.Id}, Name: {artWork.Name}");
                    return NotFound(ModelState);
                }
                else
                {
                    _artWorkService.Update(artWork);
                    return Ok("Cập nhật thành công");
                }
            }
            else
            {
                return BadRequest($"Số Lỗi: {ModelState.ErrorCount}, Lỗi: {ModelState}");
            }
        }

        [HttpPut("{id}/status")]
        public IActionResult UpdateStatus(Guid id, UpdateStatusArtwork updateStatusArtwork)
        {
            var artWorkCheck = _artWorkService.GetById(id);
            if (artWorkCheck == null)
            {
                return NotFound(ModelState);
            }
            else
            {
                artWorkCheck.ArtWorkStatus = updateStatusArtwork.Status == 1
                    ? AWS_BusinessObjects.Enums.ArtWorkStatus.Active
                    : AWS_BusinessObjects.Enums.ArtWorkStatus.Inactive;

                _artWorkService.Update(artWorkCheck);
                return Ok("Cập nhật thành công");
            }
        }

        [HttpPut("{id}/owner")]
        public IActionResult UpdateOwner(Guid id, UpdateOwnerArtwork updateOwnerArtwork)
        {
            var artWorkCheck = _artWorkService.GetById(id);
            if (artWorkCheck == null)
            {
                return NotFound(ModelState);
            }
            else
            {
                artWorkCheck.UserOwnerId = updateOwnerArtwork.UserOwnerId;
                _artWorkService.Update(artWorkCheck);
                return Ok("Cập nhật thành công");
            }
        }
    }
}
