using System;
using DotnetCore.Common.DTOs;
using FluentValidation;

namespace DotnetCore.Common.Validators
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            RuleFor(p => p.Username).NotEmpty().WithMessage("Username field is required");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Password field is required");
            RuleFor(p => p.Password).MinimumLength(3).WithMessage("Password field length is should be 3 at least");
        }
    }
}
