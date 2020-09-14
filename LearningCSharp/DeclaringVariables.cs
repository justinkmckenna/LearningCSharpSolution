using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class DeclaringVariables
    {
        [Fact]
        public void DeclaringAVariable()
        {
            // dataType identifier.
            int age;
            age = 21;
            Assert.Equal(21, age);
        }

        [Fact]
        public void InitializingVariables()
        {
            int age = 21;
            int a = 1, b = 2;
            double pay = 21.103232;
            decimal x = 23.21M;
            char c = 'a';
            var bleh = "i'm lazy";
        }

        [Fact]
        public void ValueTypesExample()
        {
            int x = 10;
            int y = x;

            x = 30;
            Assert.Equal(10, y);
        }

        [Fact]
        public void ReferenceTypeExample()
        {
            Dog x = new Dog() { Name = "Fido" };
            Dog y = x;
            y.Name = "Rover";
            Assert.Equal("Rover", x.Name);
        }

        [Fact]
        public void StringsExample()
        {
            string x = "Fido";
            string y = x;
            y = "Rover";
            Assert.Equal("Fido", x);
        }

        [Fact]
        public void StringsExample2()
        {
            var myName = "jeff";
            myName.ToUpper();
            Assert.NotEqual("JEFF", myName);

            string numbers = "";
            for(var t = 0; t < 100; t++)
            {
                numbers += t + ",";
            }

            var numbersTwo = buildingBigStrings();
            var tacos = new StringBuilder("tacos").ToString();
            Assert.Equal("tacos", tacos);
        }

        private string buildingBigStrings()
        {
            StringBuilder builder = new StringBuilder();
            for(var t = 0; t < 100; t++)
            {
                builder.Append($"{t},");
            }
            return builder.ToString();
        }
    }

    public class Dog
    {
        public string Name;
    }
}
