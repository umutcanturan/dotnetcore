using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Data.Entities
{
	public class BaseEntity
	{
		public BaseEntity()
		{
			IsActive = true;
			CreateDate = DateTime.Now;
		}

		[Key]
		public int Id { get; set; }

		[Required]
		public bool IsActive { get; set; }

		[Required]
		public DateTime CreateDate { get; set; }
	}
}
