using Application.DTOs.Common;
using Application.Services;
using Domain.Entities.Global.Kullanici;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AsdWebApi.Controllers.YonetimMerkezi
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciController : Controller
    {

        private readonly IGenericService<Kullanicilar> _kullanicilarService;
        private readonly IGenericService<Gorevler> _gorevlerService;
        private readonly IGenericService<Departmanlar> _departmanlarService;

        public KullaniciController(IGenericService<Kullanicilar> kullanicilarService, IGenericService<Gorevler> gorevlerService, IGenericService<Departmanlar> departmanlarService)
        {
            _kullanicilarService = kullanicilarService;
            _gorevlerService = gorevlerService;
            _departmanlarService = departmanlarService;
        }

        [HttpGet("GetAllDepartmanlar")]
        public async Task<JsonResult> GetAllGrup()
        {
            var data = await _departmanlarService.GetAllAsync();
            if (data == null)
            {
                return Json(ResponseDto<EmptyDto>.Fail("Departmanlar bulunamadı.", 404, true));
            }
            return Json(data);
        }

        [HttpGet("GetAllGorev/{departmanId}")]
        public async Task<JsonResult> GetAllGorev(int departmanId)
        {
            if (departmanId <= 0)
            {
                return Json(ResponseDto<EmptyDto>.Fail("Geçersiz Görev Id. Görev Id sıfırdan büyük bir değer olmalıdır."));
            }
            var data = await _gorevlerService.FindAsync(g=>g.DepartmanId == departmanId);
            if (data == null)
            {
                return Json(ResponseDto<EmptyDto>.Fail("Görevler bulunamadı.", 404, true));
            }

            return Json(data);
        }

    }
}
