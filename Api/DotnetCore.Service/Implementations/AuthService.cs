using DotnetCore.Common.DTOs;
using DotnetCore.Common.Helpers;
using DotnetCore.Repository.Interfaces;
using DotnetCore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Implementations
{
	public class AuthService : IAuthService
	{
		private readonly ICustomerRepository _customerRepository;
		public AuthService(ICustomerRepository customerRepository)
		{
			_customerRepository = customerRepository;
		}

		public CustomResponse<TokenDTO> Login(LoginDTO dto)
		{
			var user = _customerRepository.GetAll().FirstOrDefault(p => p.Email == dto.Username && p.Password == dto.Password && p.IsActive);
			if (user == null)
			{
				return null;
			}
			var token = AuthHelper.Authenticate(user.Id.ToString());
			var result = new TokenDTO()
			{
				Token = token,
				UserId = user.Id
			};
			return new CustomResponse<TokenDTO>(true, result);
		}

		public CustomResponse<TokenDTO> Register(RegisterDTO dto)
		{
			var user = _customerRepository.GetAll().FirstOrDefault(p => p.Email == dto.Email);
			if (user == null)
			{
				user = _customerRepository.Add(new Data.Entities.Customer()
				{
					Email = dto.Email,
					Password = dto.Password,
					FullName = dto.FullName
				});
				var token = AuthHelper.Authenticate(user.Id.ToString());
				var result = new TokenDTO()
				{
					Token = token,
					UserId = user.Id
				};
				return new CustomResponse<TokenDTO>(true, result);
			}
			return Login(new LoginDTO()
			{
				Username = dto.Email,
				Password = dto.Password
			});
		}
	}
}
