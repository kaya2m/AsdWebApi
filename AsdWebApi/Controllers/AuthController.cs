using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.DTOs;
using Domain.Entities.Global.Kullanici;
using Application.Services;
using Repository.Tools;
using Application.DTOs.Common;
using Domain.Token;

namespace AsdWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IGenericService<Kullanicilar> _kullaniciService;
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;

        public AuthController(IGenericService<Kullanicilar> kullaniciService, IConfiguration configuration, ITokenService tokenService)
        {
            _kullaniciService = kullaniciService;
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public JsonResult Login(LoginDto loginDto)
        {
            var userName = loginDto.KullaniciAdi.ToLower().Trim();
            var encryptedPassword = ConvertTool.Base64Encode(loginDto.Sifre);

            var user = _kullaniciService
                .Where(x => x.KullaniciAdi.ToLower() == userName && x.Sifre == encryptedPassword)
                .Data.SingleOrDefault();

            if (user == null || !user.isActive)
            {
                return Json(ResponseDto<EmptyDto>.Fail("Kullanıcı adı veya şifre hatalı ya da kullanıcı pasif durumda."));
            }

            var token = _tokenService.CreateToken(user);
            return Json(token);
        }

        [HttpPost("logout")]
        [Authorize]
        public IActionResult Logout()
        {
            return Ok(new { message = "Çıkış başarılı." });
        }
    }
}
