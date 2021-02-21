using DotnetCore.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Interfaces
{
	public interface IOrderService
	{
		CustomResponse<OrderDTO> New(OrderDTO dto);
		CustomResponse<List<OrderDTO>> GetCustomerOrders(int customerId);
		CustomResponse<OrderDTO> Get(int id);
		CustomResponse<List<OrderDTO>> GetAll();
	}
}
