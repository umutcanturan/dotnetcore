using AutoMapper;
using DotnetCore.Common.DTOs;
using DotnetCore.Repository.Interfaces;
using DotnetCore.Service.Implementations;
using DotnetCore.Service.Interfaces;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DotnetCore.Api.Test
{
	public class OrderTest
	{
		[Fact]
		public void NewOrderService()
		{
			var orderRepository = A.Fake<IOrderRepository>();
			var productRepository = A.Fake<IProductRepository>();
			var mapper = A.Fake<IMapper>();
			var orderService = new OrderService(productRepository, orderRepository, mapper);
			var order = new OrderDTO()
			{
				Amount = 100,
				CustomerId = 1,
				ProductId = 1,
				Status = Common.Enums.OrderStatus.Waiting
			};
			var response = orderService.New(order);
			Assert.True(response.ResultCode == Common.Enums.ResponseResult.NotStockAmount);
		}

		[Fact]
		public void NewOrderApi()
		{
			var orderService = A.Fake<IOrderService>();
			var order = A.Fake<OrderDTO>();
			orderService.New(order);
			A.CallTo(() => orderService.New(A<OrderDTO>._)).MustHaveHappenedOnceExactly();
		}
	}
}
