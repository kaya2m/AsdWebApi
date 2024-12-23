using Application.DTOs.Common;
using Application.Services;
using Domain.Entities.Global.Kullanici;
using Microsoft.AspNetCore.Mvc;

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
    }
}
