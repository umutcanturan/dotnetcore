using AutoMapper;
using DotnetCore.Common.DTOs;
using DotnetCore.Common.Enums;
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
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;
		public OrderService(IProductRepository productRepository, IOrderRepository orderRepository, IMapper mapper)
		{
			_orderRepository = orderRepository;
			_productRepository = productRepository;
			_mapper = mapper;
		}

		public CustomResponse<OrderDTO> Get(int id)
		{
			var order = _orderRepository.Get(id);
			if(order == null)
			{
				return new CustomResponse<OrderDTO>(false, null, ResponseResult.NotFound);
			}
			return new CustomResponse<OrderDTO>(true, _mapper.Map<OrderDTO>(order));
		}

		public CustomResponse<List<OrderDTO>> GetCustomerOrders(int customerId)
		{
			var orders = _orderRepository.GetAll().Where(p => p.CustomerId == customerId && p.IsActive).ToList().Select(p => _mapper.Map<OrderDTO>(p)).ToList();
			return new CustomResponse<List<OrderDTO>>(true, orders);
		}

		public CustomResponse<OrderDTO> New(OrderDTO dto)
		{
			var product = _mapper.Map<ProductDTO>(_productRepository.Get(dto.ProductId));
			if (product == null)
			{
				return new CustomResponse<OrderDTO>(false, "Product is not found", null, ResponseResult.NotFound);
			}
			if (!_productRepository.UpdateStock(dto))
			{
				return new CustomResponse<OrderDTO>(false, "Stock is not enough" ,null, ResponseResult.NotStockAmount);
			}
			dto.Status = OrderStatus.Waiting;
			var entity = _mapper.Map<Order>(dto);
			entity = _orderRepository.Add(entity);
			entity.ProductId = dto.ProductId;
			dto.Id = entity.Id;
			return new CustomResponse<OrderDTO>(true, dto);
		}
	}
}
