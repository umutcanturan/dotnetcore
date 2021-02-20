using System;
namespace DotnetCore.Common.DTOs
{
    public class BaseDTO
    {
		public BaseDTO()
		{
			IsActive = true;
			CreateDate = DateTime.Now;
		}
		public int Id { get; set; }

		public bool IsActive { get; set; }

		public DateTime CreateDate { get; set; }
	}
}
