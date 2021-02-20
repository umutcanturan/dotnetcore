using DotnetCore.Common.DTOs;
using DotnetCore.Data.Entities;
using DotnetCore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Repository.Implementations
{
	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		public bool UpdateStock(OrderDTO dto)
		{
			var product = Context.Products.FirstOrDefault(p => p.Id == dto.ProductId);
			if(product != null && product.Stock >= dto.Amount)
			{
				product.Stock -= dto.Amount;
				return Context.SaveChanges() > 0;
			}
			return false;
		}
	}
}
