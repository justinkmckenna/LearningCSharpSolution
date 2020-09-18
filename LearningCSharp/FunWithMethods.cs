using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class FunWithMethods
    {
        [Fact]
        public void OverloadingMethods()
        {
            var thingy = new Thingy();

            var fullName = thingy.FormatName("Han", "Solo");
            Assert.Equal("Solo, Han", fullName);

            fullName = thingy.FormatName("Han", "Solo", "D");
            Assert.Equal("Solo, Han D.", fullName);
        }

        [Fact]
        public void DefaultArgsMethods()
        {
            var thingy = new Thingy();

            var fullName = thingy.FormatNameDefault("Han", "Solo");
            Assert.Equal("Solo, Han M.", fullName);

            fullName = thingy.FormatNameDefault("Han", "Solo", "D");
            Assert.Equal("Solo, Han D.", fullName);
        }

        [Fact]
        public void Params()
        {
            var result = new Thingy().Add(10, 15, 20);
            Assert.Equal(45, result);
        }
    }
}
