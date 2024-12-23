using Domain.Entities.Global.Kullanici;
using Domain.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ITokenService
    {
        TokenResult CreateToken(Kullanicilar kullanici);
    }
}
