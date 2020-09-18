using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class DTOs
    {
        [Fact]
        public void DoingThem()
        {
            AddCustomer(new Customer()
            {
                First = "justin",
                Last = "mckenna",
                Address = "my address",
                Phone = "123-123-1231"
            });
        }

        public void AddCustomer(Customer customer)
        {
            // add customer
        }

        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
        }
    }
}
