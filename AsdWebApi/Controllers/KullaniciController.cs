using Application.DTOs.Common;
using Application.Services;
using Domain.Entities.Global.Kullanici;
using Microsoft.AspNetCore.Mvc;
using Repository.Tools;

namespace AsdWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KullaniciController : Controller
    {
        private readonly IGenericService<Kullanicilar> _kullanicilar;
        private readonly IGenericService<Birimler> _birimler;

        public KullaniciController(IGenericService<Kullanicilar> kullanicilar, IGenericService<Birimler> birimler)
        {
            _kullanicilar = kullanicilar;
            _birimler = birimler;
        }

        [HttpGet("GetAll")]
        public async Task<JsonResult> GetAllUser()
        {
            var data = await _kullanicilar.GetAllAsync();
            return Json(data);
        }
        [HttpPost("CreateUser")]
        public async Task<JsonResult> CreateUser()
        {
            var user = new Kullanicilar()
            {
                Ad = "admin",
                Soyad = "admin",
                KullaniciAdi = "admin",
                Sifre = ConvertTool.Base64Encode("password"),
                Mail = "admin@asdlaminat.com",
                Birim_Id=1,
                Gorev_Id=5,
                Grup_Id=1,
            };
            var newUser = await _kullanicilar.AddAsync(user);
            if (newUser.IsSuccessful)
            {
                return Json(ResponseDto<EmptyDto>.Success("Başarıyla eklendi"));
            }
           else
                return Json(ResponseDto<EmptyDto>.Fail("eklenirken bir hata meydana geldi"));
        }

        [HttpGet("Birimler")]
        public async Task<JsonResult> Birimler()
        {
            var data = await _birimler.GetAllAsync();
            return Json(data);

        }

        [HttpPost("BirimEkle")]
        public async Task<JsonResult> CreateBirim()
        {
            var birim = new Birimler()
            {
                Adi = "Birim",
                Acıklama = "Birim Açıklama",
            };
            var ekle = await _birimler.AddAsync(birim);
            if (ekle.IsSuccessful)
            {

                return Json(ResponseDto<EmptyDto>.Success("Başarıyla eklendi"));
            }
            else
            {
                return Json(ResponseDto<EmptyDto>.Fail("eklenirken bir hata meydana geldi"));
            }
        }

        [HttpDelete("BirimSil")]
        public async Task<JsonResult> DeleteBirim()
        {
            var birim = await _birimler.GetByIdAsync(1);
            if (birim is not null)
            {
                var islem = _birimler.SoftRemove(1);
                if (islem.IsSuccessful)
                {
                    return Json(ResponseDto<EmptyDto>.Success("Başaırlı soft delete"));
                }
                else
                {
                    return Json(ResponseDto<EmptyDto>.Fail("başarısız"));
                }
            }
            else
            {
                return Json(ResponseDto<EmptyDto>.Fail("Birim bulunamadı"));
            }

        }
    }
}
