using DotnetCore.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Interfaces
{
	public interface ICustomerService
	{
		Task<CustomResponse<CustomerDTO>> NewAsync(CustomerDTO dto);
		CustomResponse<List<CustomerDTO>> GetAll();
	}
}
