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
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;
		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpPost]
		public IActionResult New([FromBody] OrderDTO dto)
		{
			return Ok(_orderService.New(dto));
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_orderService.GetAll());
		}

		[HttpGet]
		[Route("{id:int}")]
		public IActionResult Get(int id)
		{
			return Ok(_orderService.Get(id));
		}

		[HttpGet]
		public IActionResult GetCustomerOrders([FromQuery] int customerId)
		{
			return Ok(_orderService.GetCustomerOrders(customerId));
		}
	}
}
