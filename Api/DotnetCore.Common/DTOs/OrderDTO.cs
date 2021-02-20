using DotnetCore.Common.Enums;
using System;
namespace DotnetCore.Common.DTOs
{
    public class OrderDTO : BaseDTO
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public OrderStatus Status { get; set; }
        public int CustomerId { get; set; }
    }
}
