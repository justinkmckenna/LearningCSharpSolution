using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class BankCustomer
    {
        private int _accountNum; //backing field
        public string name { get; set; } // auto property - compiler creates backing fields, etc.
                                         // cant put logic into these either, must make custom property, like accountnumber
        public string PhoneNum { get; private set; } // can get prop but not set it from outside class methods

        public int AccountNumber //property
        {
            get { return _accountNum; } //getter
            set { _accountNum = value; } //setter
        }
    }

    public class UsingProperties
    {
        [Fact]
        public void DefiningAndUsingProperties()
        {
            var customer = new BankCustomer() { name = "justin", AccountNumber = 123 };
            // customer.PhoneNum = "555055505555"; // cant do this
            // var cust2 = new BankCustomer() { PhoneNum = "555055505555" }; // cant do this either
        }
    }
}
