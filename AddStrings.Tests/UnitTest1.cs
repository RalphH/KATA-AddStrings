using System;
using Xunit;

namespace AddStrings.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void LessThan10()
        {
            Assert.Equal(5, Kata.AddStrings("2, 3"));
        }

        [Fact]
        public void Over50()
        {
            Assert.Equal(60, Kata.AddStrings("20, 20, 20"));
        }
    }
}


