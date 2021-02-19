using DotnetCore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Data.Entities
{
	public class Order : BaseEntity
	{
		public string ProductName { get; set; }
		public int Amount { get; set; }
		public OrderStatus Status { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer Customer { get; set; }
	}
}
