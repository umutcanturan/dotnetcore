using DotnetCore.Common.DTOs;
using DotnetCore.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService _authService;
		public AuthController(IAuthService authService)
		{
			_authService = authService;
		}

		[HttpPost]
		[Route("signin")]
		public IActionResult SignIn([FromBody] LoginDTO dto)
		{
			var result = _authService.Login(dto);
			if (result == null)
			{
				return StatusCode(StatusCodes.Status401Unauthorized, "Status401Unauthorized");
			}
			return Ok(result);
		}

		[HttpPost]
		[Route("signup")]
		public IActionResult SignUp([FromBody] RegisterDTO dto)
		{
			var result = _authService.Register(dto);
			if (result == null)
			{
				return StatusCode(StatusCodes.Status401Unauthorized, "Status401Unauthorized");
			}
			return Ok(result);
		}
	}
}
