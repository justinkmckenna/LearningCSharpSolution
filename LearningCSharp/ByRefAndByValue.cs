using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class ByRefAndByValue
    {
        [Fact]
        public void ShowingIt()
        {
            int x = 10, y = 20;
            MessWithThem(ref x, ref y);
            Assert.Equal(20, x);
            Assert.Equal(40, y);
        }


        [Fact]
        public void UsingAnOutParam()
        {
            var fullName = FormatName("Luke", "sky", out int x);
            Assert.Equal("sky, Luke", fullName);
            Assert.Equal(15, x);
        }

        [Fact]
        public void AnExample()
        {
            var age = "51";
            if (int.TryParse(age, out int numberAge))
            {
                Assert.Equal(51, numberAge);
            }
        }

        [Fact]
        public void SwappingThings()
        {
            int x = 1, y = 2;
            Swap(ref x, ref y);
            Assert.Equal(2, x);
            Assert.Equal(1, y);
        }

        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public void MessWithThem(ref int a, ref int b)
        {
            a = a * 2;
            b = b * 2;
        }

        public string FormatName(string f, string l, out int count)
        {
            var fullName = $"{l}, {f}";
            count = 15;
            return fullName;
        }
    }
}
