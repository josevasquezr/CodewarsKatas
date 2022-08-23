using KatasTrainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTraining.Tests
{
    public class GreedIsGoodTest
    {
        [Theory]
        [InlineData(250, new int[] { 5, 1, 3, 4, 1 })]
        [InlineData(1100, new int[] { 1, 1, 1, 3, 1 })]
        [InlineData(450, new int[] { 2, 4, 4, 5, 4 })]
        public void Score(int expected, int[] dice)
        {
            //arrange
            GreedIsGood greedIsGood = new GreedIsGood();

            //act
            int result = greedIsGood.Score(dice);

            //asserts
            Assert.Equal(expected, result);
        }

        [Fact]
        public static void ShouldBeWorthless()
        {
            GreedIsGood greedIsGood = new GreedIsGood();
            Assert.Equal(0, greedIsGood.Score(new int[] { 2, 3, 4, 6, 2 }));
        }

        [Fact]
        public static void ShouldValueTriplets()
        {
            GreedIsGood greedIsGood = new GreedIsGood();
            Assert.Equal(400, greedIsGood.Score(new int[] { 4, 4, 4, 3, 3 }));
        }

        [Fact]
        public static void ShouldValueMixedSets()
        {
            GreedIsGood greedIsGood = new GreedIsGood();
            Assert.Equal(450, greedIsGood.Score(new int[] { 2, 4, 4, 5, 4 }));
        }
    }
}
