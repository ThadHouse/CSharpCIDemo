using System;
using Xunit;

namespace Application.Test
{
    public class ArithmaticTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        public void TestAdd(int a, int b, int expectedResult)
        {
            var arithmatic = new Arithmatic();
            Assert.Equal(expectedResult, arithmatic.Add(a, b));
        }
    }
}
