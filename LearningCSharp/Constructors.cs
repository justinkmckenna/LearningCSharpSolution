using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace LearningCSharp
{
    public class Constructors
    {

        private ITestOutputHelper _output;

        public Constructors(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void HiringSomeone()
        {
            // var employee = new Employee(); //error, must pass args
            var employee = new Employee("justin", "prog", "123");
            var sue = new Employee("sue", "prog1", "123");
            var judy = new Retiree("judy", "prog2", 123);

            var folks = new List<Person>() { employee, sue, judy };

            GiveThemARaise(sue, 100);
            // GiveThemARaise(judy, 100); // doesn't work because Retiree doesn't inherit from ICanBeGivenARaised

            foreach (var person in folks)
            {
                _output.WriteLine(person.GetInfo());
            }
        }

        public void GiveThemARaise(ICanBeGivenARaise person, decimal amount)
        {
            person.GiveRaise(amount);
        }
    }

    public interface ICanBeGivenARaise
    {
        void GiveRaise(decimal amount);
    }

    public abstract class Person
    {
        public Person(string name, string dept) { Name = name; Dept = dept; }
        public string Name { get; protected set; }
        public string Dept { get; protected set; }

        public virtual string GetInfo()
        {
            return $"{Name} works in {Dept} making {GetCompensation()}.";
        }

        public abstract string GetCompensation();
    }

    public class Employee : Person, ICanBeGivenARaise
    {
        public Employee(string name, string dept, string salary) : base(name, dept)
        {
            Salary = salary;
        }
        // OR
        public Employee(string name, string dept) : this(name, dept, "0") { } // except you need the above ctor to do this, trash

        public string Salary { get; private set; }

        public override string GetCompensation()
        {
            return Salary;
        }

        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }
    }

    public class Retiree : Person
    {
        public Retiree(string name, string dept, decimal pension) : base(name, dept)
        {
            Pension = pension;
        }
        public decimal Pension { get; private set; }

        public override string GetCompensation()
        {
            return Pension.ToString();
        }
    }
}
