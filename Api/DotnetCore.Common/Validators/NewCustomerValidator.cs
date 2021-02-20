using DotnetCore.Common.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.Validators
{
	public class NewCustomerValidator : AbstractValidator<CustomerDTO>
	{
		public NewCustomerValidator()
		{
			RuleFor(p => p.Email).NotEmpty().WithMessage("Email field is required");
			RuleFor(p => p.FullName).NotEmpty().WithMessage("Full name field is required");
			RuleFor(p => p.Password).NotEmpty().WithMessage("Password field is required");
			RuleFor(p => p.Password).MinimumLength(3).WithMessage("Password field length is should be 3 at least");
		}
	}
}
