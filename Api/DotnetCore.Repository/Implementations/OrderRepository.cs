using DotnetCore.Data.Entities;
using DotnetCore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Repository.Implementations
{
	public class OrderRepository : BaseRepository<Order>, IOrderRepository
	{
	}
}
