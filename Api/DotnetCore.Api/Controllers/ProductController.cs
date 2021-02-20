using DotnetCore.Common.DTOs;
using DotnetCore.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	[Authorize]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpPost]
		public IActionResult New([FromBody] ProductDTO dto)
		{
			return Ok(_productService.New(dto));
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_productService.GetAll());
		}
	}
}
