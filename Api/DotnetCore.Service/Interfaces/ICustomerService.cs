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
		CustomResponse<CustomerDTO> New(CustomerDTO dto);
		CustomResponse<List<CustomerDTO>> GetAll();
	}
}
