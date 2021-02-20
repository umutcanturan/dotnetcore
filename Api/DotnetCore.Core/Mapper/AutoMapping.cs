using AutoMapper;
using DotnetCore.Common.DTOs;
using DotnetCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Core.Mapper
{
	public class AutoMapping : Profile
	{
		public AutoMapping()
		{
			CreateMap<Order, OrderDTO>().ReverseMap();
			CreateMap<Customer, CustomerDTO>().ReverseMap();
			CreateMap<Product, ProductDTO>().ReverseMap();
		}
	}
}
