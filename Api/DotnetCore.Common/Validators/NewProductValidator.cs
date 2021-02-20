using DotnetCore.Common.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.Validators
{
	public class NewProductValidator : AbstractValidator<ProductDTO>
	{
		public NewProductValidator()
		{
			RuleFor(p => p.Name).NotEmpty().WithMessage("Product name is required");
		}
	}
}
