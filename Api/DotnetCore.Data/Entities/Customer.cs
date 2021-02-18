using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Data.Entities
{
	public class Customer : BaseEntity
	{
		public string FullName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public virtual ICollection<Order> Orders { get; set; }
	}
}
