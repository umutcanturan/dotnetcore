using DotnetCore.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Interfaces
{
	public interface IProductService
	{
		CustomResponse<ProductDTO> New(ProductDTO dto);

		CustomResponse<List<ProductDTO>> GetAll();
	}
}
