using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.DTOs
{
	public class ProductDTO : BaseDTO
	{
		public int Stock { get; set; }

		public string Name { get; set; }
	}
}
