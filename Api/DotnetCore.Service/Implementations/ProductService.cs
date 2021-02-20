using AutoMapper;
using DotnetCore.Common.DTOs;
using DotnetCore.Data.Entities;
using DotnetCore.Repository.Interfaces;
using DotnetCore.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Service.Implementations
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;
		public ProductService(IProductRepository productRepository, IMapper mapper)
		{
			_productRepository = productRepository;
			_mapper = mapper;
		}

		public CustomResponse<List<ProductDTO>> GetAll()
		{
			var products = _productRepository.GetAll().Where(p => p.IsActive).ToList().Select(p => _mapper.Map<ProductDTO>(p)).ToList();
			return new CustomResponse<List<ProductDTO>>(true, products);
		}

		public CustomResponse<ProductDTO> New(ProductDTO dto)
		{
			var entity = _mapper.Map<Product>(dto);
			entity = _productRepository.Add(entity);
			dto.Id = entity.Id;
			return new CustomResponse<ProductDTO>(true, dto);
		}
	}
}
