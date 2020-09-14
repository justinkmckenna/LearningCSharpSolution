using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Xunit;

namespace LearningCSharp
{
    public class Collections
    {
        [Fact]
        public void MyFavoriteNumbers()
        {
            var myFavoriteNumbers = new ArrayList();
            myFavoriteNumbers.Add(8);
            myFavoriteNumbers.Add(20);
            myFavoriteNumbers.Add(2);

            Assert.Equal(8, myFavoriteNumbers[0]);
            // Assert.Equal(99, myFavoriteNumbers[3]); //runtime error
            myFavoriteNumbers[1] = 22;
            Assert.Equal(22, myFavoriteNumbers[1]);

            myFavoriteNumbers.Add("Tacos");
            // var firstTwo = myFavoriteNumbers[0] + myFavoriteNumbers[1]; // wont build, + not overloaded for objects
            var firstTwo = ((int) myFavoriteNumbers[0]) + ((int) myFavoriteNumbers[1]); // not great code
            Assert.Equal(30, firstTwo);
        }

        [Fact]
        public void Generics()
        {
            var myFavoriteNumbers = new List<int>();
            // "parametric polymorphism"
            myFavoriteNumbers.Add(2);
            myFavoriteNumbers.Add(3);

            var firstTwo = myFavoriteNumbers[0] + myFavoriteNumbers[1];
            Assert.Equal(5, firstTwo);
        }

        [Fact]
        public void InitializeList()
        {
            var favFoods = new List<string> { "tacos", "beer" };
            Assert.Equal("beer", favFoods[1]);
        }

        [Fact]
        public void Enumeration()
        {
            var nums = new List<int> { 1, 2, 3, 4 };
            var total = 0; // there are better ways to sum
            foreach(var n in nums)
            {
                total += n;
            }
            Assert.Equal(10, total);
            Assert.Equal(10, nums.Sum()); // the better way
        }

        [Fact]
        public void Dictionaries()
        {
            var friends = new Dictionary<char, string>
            {
                { 's', "sean" },
                { 'j', "justin" },
                { 'b', "bob" }
            };
            friends.Add('d', "david");
            Assert.Equal("sean", friends['s']);
            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsValue("wow"));

            //emumerating keys
            foreach(char key in friends.Keys)
            {
                //'s', 'j', 'd'
            }
            
            // enumerating values 
            foreach(string value in friends.Values)
            {
                //"sean", "justin", "bob"
            }

            // enumerating both
            foreach(KeyValuePair<char, string> kvp in friends)
            {
                //kvp.Key == "s" and kvp.Value == "sean" etc.
            }
        }
    }
}
