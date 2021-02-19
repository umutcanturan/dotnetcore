using System;
using System.Collections.Generic;

namespace DotnetCore.Common.DTOs
{
    public class CustomerDTO : BaseDTO
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }

        public List<OrderDTO> Orders { get; set; }
    }
}
