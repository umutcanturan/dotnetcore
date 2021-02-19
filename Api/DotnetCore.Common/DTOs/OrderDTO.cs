using System;
namespace DotnetCore.Common.DTOs
{
    public class OrderDTO : BaseDTO
    {
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public int Status { get; set; }
        public int CustomerId { get; set; }
    }
}
