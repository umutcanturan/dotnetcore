using DotnetCore.Core.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Core.Configuration
{
	public class MapperConfiguration
	{
		public static void Init(IServiceCollection services)
		{
			services.AddAutoMapper(typeof(AutoMapping));
		}
	}
}
