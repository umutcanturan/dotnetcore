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
	public class CustomerService : ICustomerService
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

		public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
		{
			_customerRepository = customerRepository;
			_mapper = mapper;
		}
		public CustomResponse<List<CustomerDTO>> GetAll()
		{
			var customers = _customerRepository.GetAll().Where(p => p.IsActive).ToList().Select(p => _mapper.Map<CustomerDTO>(p)).ToList();
			return new CustomResponse<List<CustomerDTO>>(true, customers);
		}

		public CustomResponse<CustomerDTO> New(CustomerDTO dto)
		{
			var entity = _mapper.Map<Customer>(dto);
			entity = _customerRepository.Add(entity);
			dto.Id = entity.Id;
			return new CustomResponse<CustomerDTO>(true, dto);
		}
	}
}
