using DotnetCore.Common.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.Validators
{
	public class NewOrderValidator : AbstractValidator<OrderDTO>
	{
		public NewOrderValidator()
		{
			RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name field is required");
			RuleFor(p => p.CustomerId).NotEqual(0).WithMessage("Customer cannot be empty");
			RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Order count should be greater than zero");
		}
	}
}
