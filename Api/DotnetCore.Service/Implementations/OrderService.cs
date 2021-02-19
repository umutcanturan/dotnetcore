using DotnetCore.Common.DTOs;
using DotnetCore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Implementations
{
	public class OrderService : IOrderService
	{
		public CustomResponse<OrderDTO> Get(int id)
		{
			throw new NotImplementedException();
		}

		public CustomResponse<List<OrderDTO>> GetCustomerOrders(int customerId)
		{
			throw new NotImplementedException();
		}

		public CustomResponse<OrderDTO> New(OrderDTO dto)
		{
			throw new NotImplementedException();
		}
	}
}
