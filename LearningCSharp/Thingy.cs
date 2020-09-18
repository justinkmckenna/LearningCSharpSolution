using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LearningCSharp
{
    public class Thingy
    {
        public string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public string FormatName(string first, string last, string mi)
        {
            return $"{last}, {first} {mi}.";
        }

        public string FormatNameDefault(string first, string last, string mi = "M")
        {
            return $"{last}, {first} {mi}.";
        }

        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
