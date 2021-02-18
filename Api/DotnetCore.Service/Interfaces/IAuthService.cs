using DotnetCore.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Interfaces
{
	public interface IAuthService
	{
		CustomResponse<TokenDTO> Login(LoginDTO dto);

		CustomResponse<TokenDTO> Register(RegisterDTO dto);
	}
}
