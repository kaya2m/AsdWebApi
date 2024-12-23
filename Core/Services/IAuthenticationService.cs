using Application.DTOs;
using Application.DTOs.Common;
using Domain.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IAuthenticationService
    {
        ResponseDto<TokenResult> CreateToken(LoginDto loginDto);
    }
}
