using Application.DTOs;
using Application.DTOs.Common;
using Application.Services;
using Azure;
using Domain.Entities.Global.Kullanici;
using Domain.Token;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Repository.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly ITokenService _tokenService;
        private readonly IGenericService<Kullanicilar> _kullanicilar;

        public AuthenticationService(ITokenService tokenService, IGenericService<Kullanicilar> kullanicilar)
        {
            _tokenService = tokenService;
            _kullanicilar = kullanicilar;
        }

        public ResponseDto<TokenResult> CreateToken(LoginDto loginDto)
        {
            try
            {
                if (loginDto == null)
                    throw new ArgumentNullException(nameof(loginDto));

                var kullanici = _kullanicilar.Where(x => x.KullaniciAdi == loginDto.KullaniciAdi && x.Sifre == ConvertTool.Base64Encode(loginDto.Sifre)).Data.SingleOrDefault();

                if (kullanici == null)
                    return ResponseDto<TokenResult>.Fail("Kullanıcı adı veya şifre hatalı.", 404, true);

                
                var token = _tokenService.CreateToken(kullanici);

                return ResponseDto<TokenResult>.Success(token, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<TokenResult>.Fail(new ErrorDto(ex.Message, false), "Token oluşturulurken sistemsel bir hata meydana geldi.", 500);
            }
        }
    }
}
