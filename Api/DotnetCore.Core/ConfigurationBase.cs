using DotnetCore.Core.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Core
{
	public class ConfigurationBase
	{
		public static void Init(IServiceCollection services)
		{
			ServiceConfiguration.Inject(services);
			ValidatorConfiguration.Inject(services);
			MapperConfiguration.Init(services);
		}
	}
}
