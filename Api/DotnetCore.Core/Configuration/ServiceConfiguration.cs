using DotnetCore.Data;
using DotnetCore.Data.Factory;
using DotnetCore.Repository.Implementations;
using DotnetCore.Repository.Interfaces;
using DotnetCore.Service.Implementations;
using DotnetCore.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetCore.Core.Configuration
{
	public class ServiceConfiguration
	{
		public static void Inject(IServiceCollection services)
		{
			services.AddDbContext<DatabaseContext>();
			services.AddTransient<ICustomerRepository, CustomerRepository>();
			services.AddTransient<IOrderRepository, OrderRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
			services.AddTransient<IOrderService, OrderService>();
			services.AddTransient<ICustomerService, CustomerService>();
			services.AddTransient<IAuthService, AuthService>();
			services.AddTransient<IProductService, ProductService>();
		}
	}
}
