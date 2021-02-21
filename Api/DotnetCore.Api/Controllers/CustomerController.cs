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
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _customerService;
		private readonly IOrderService _orderService;
		public CustomerController(ICustomerService customerService, IOrderService orderService)
		{
			_customerService = customerService;
			_orderService = orderService;
		}

		[HttpPost]
		public async Task<IActionResult> New([FromBody] CustomerDTO dto)
		{
			return Ok(await _customerService.NewAsync(dto));
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_customerService.GetAll());
		}

		[HttpGet]
		public IActionResult GetOrders()
		{
			return Ok(_orderService.GetCustomerOrders(Convert.ToInt32(User.Identity.Name)));
		}
	}
}
