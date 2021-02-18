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
		public int Status { get; set; }
	}
}
