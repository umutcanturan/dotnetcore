using DotnetCore.Common.DTOs;
using DotnetCore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Implementations
{
	public class CustomerService : ICustomerService
	{
		public CustomResponse<List<CustomerDTO>> GetAll()
		{
			throw new NotImplementedException();
		}

		public CustomResponse<CustomerDTO> New(CustomerDTO dto)
		{
			throw new NotImplementedException();
		}
	}
}
