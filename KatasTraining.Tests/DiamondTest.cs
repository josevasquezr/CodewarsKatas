using KatasTrainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTraining.Tests
{
    public class DiamondTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(2)]
        public void PrintTestNull(int n)
        {
            //arrange
            Diamond diamond = new Diamond();

            //act
            string result = diamond.Print(n);

            //asserts
            Assert.Null(result);
        }

        [Theory]
        [InlineData("*\n", 1)]
        [InlineData(" *\n***\n *\n", 3)]
        [InlineData("  *\n ***\n*****\n ***\n  *\n", 5)]
        public void Print(string expected, int n)
        {
            //arrange
            Diamond diamond = new Diamond();

            //act
            string result = diamond.Print(n);

            //asserts
            Assert.Equal(expected, result);
        }

    }
}
