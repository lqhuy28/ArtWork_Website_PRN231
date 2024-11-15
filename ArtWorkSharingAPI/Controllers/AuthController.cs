using Microsoft.AspNetCore.Mvc;
using AWS_BusinessObjects.Models;
using AWS_Repository.Identity;
using System.Threading.Tasks;

namespace ArtWorkSharingAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AuthController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            try
            {
                var result = await _accountRepository.SignUpAsync(model);
                if (result.Succeeded)
                {
                    return Ok(result.Succeeded);
                }
                return BadRequest(result.Errors);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            var result = await _accountRepository.SignInAsync(model);
            if (result == null)
            {
                return BadRequest("Sai tên đăng nhập hoặc mật khẩu!");
            }
            return Ok(result);
        }

        [HttpGet("audience")]
        public async Task<IActionResult> GetAudienceAccounts()
        {
            var result = await _accountRepository.GetAudienceAcountAsync();
            return Ok(result);
        }

        [HttpGet("artists")]
        public async Task<IActionResult> GetArtistAccounts()
        {
            var result = await _accountRepository.GetArtistAcountAsync();
            return Ok(result);
        }

        [HttpGet("administrators")]
        public async Task<IActionResult> GetAdministratorAccounts()
        {
            var result = await _accountRepository.GetAdministratorAcountAsync();
            return Ok(result);
        }

        [HttpPut("ban/{email}")]
        public async Task<IActionResult> BanAccount(string email)
        {
            var result = await _accountRepository.LockoutEnableAccount(email);
            if (result)
            {
                return Ok("Account has been banned");
            }
            return BadRequest("Could not ban the account");
        }

        [HttpPut("unban/{email}")]
        public async Task<IActionResult> UnbanAccount(string email)
        {
            var result = await _accountRepository.LockoutDisableAccount(email);
            if (result)
            {
                return Ok("Account has been unbanned");
            }
            return BadRequest("Could not unban the account");
        }

        [HttpGet("artists/{id}")]
        public async Task<IActionResult> GetArtistById(string id)
        {
            var result = await _accountRepository.GetAccountByIdAsync(id);
            if (result == null)
            {
                return NotFound($"Không tìm thấy tài khoản của bạn!, Id: {id}");
            }
            return Ok(result);
        }

        [HttpGet("audiences/{id}")]
        public async Task<IActionResult> GetAudienceById(string id)
        {
            var result = await _accountRepository.GetAccountByIdAsync(id);
            if (result == null)
            {
                return NotFound($"Không tìm thấy tài khoản của bạn!, Id: {id}");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(string id)
        {
            var result = await _accountRepository.GetAccountByIdAsync(id);
            if (result == null)
            {
                return NotFound($"Không tìm thấy tài khoản của bạn!, Id: {id}");
            }
            return Ok(result);
        }
    }
}
