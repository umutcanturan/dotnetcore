﻿using DotnetCore.Common.DTOs;
using DotnetCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Repository.Interfaces
{
	public interface IProductRepository : IBaseRepository<Product>
	{
		bool UpdateStock(OrderDTO dto);
	}
}
