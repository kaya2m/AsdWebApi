using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class LoginDto
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool BeniHatirla { get; set; }
    }
}
