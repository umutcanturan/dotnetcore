using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.Enums
{
	public enum OrderStatus
	{
		Waiting = 0,
		Preparing = 10,
		Delivering = 20,
		Completed = 30,
		Canceled = 40
	}
}
