using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Data.Entities
{
	public class Product : BaseEntity
	{
		public int Stock { get; set; }

		public string Name { get; set; }
	}
}
