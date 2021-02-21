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
	public class CustomerTest
	{
		[Fact]
		public async Task NewCustomerApi()
		{
			var customerService = A.Fake<ICustomerService>();
			var customer = A.Fake<CustomerDTO>();
			await customerService.NewAsync(customer);
			A.CallTo(() => customerService.NewAsync(A<CustomerDTO>._)).MustHaveHappenedOnceExactly();
		}
	}
}
