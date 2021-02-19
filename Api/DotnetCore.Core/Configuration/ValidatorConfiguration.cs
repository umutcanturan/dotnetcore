using System;
using DotnetCore.Common.DTOs;
using DotnetCore.Common.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetCore.Core.Configuration
{
    public class ValidatorConfiguration
    {
        public static void Inject(IServiceCollection services)
        {
            services.AddTransient<IValidator<LoginDTO>, LoginValidator>();
        }
    }
}
