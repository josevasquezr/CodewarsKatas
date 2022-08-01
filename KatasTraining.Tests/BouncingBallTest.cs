using KatasTrainings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTraining.Tests
{
    public class BouncingBallTest
    {
        [Theory]
        [InlineData(15, 30.0, 0.66, 1.5)]
        [InlineData(3, 3.0, 0.66, 1.5)]
        [InlineData(-1, 3, 1, 1.5)]
        public void GetBouncingBall(int expected, double heigth, double bounce, double window)
        {
            //arrange
            BouncingBall bouncingBall = new BouncingBall();
            int result;

            //act
            result = bouncingBall.GetBouncingBall(heigth, bounce, window);

            //asserts
            Assert.Equal(expected, result);
        }
    }
}
