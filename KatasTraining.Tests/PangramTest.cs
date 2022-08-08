using KatasTrainings;

namespace KatasTraining.Tests
{
    public class PangramTest
    {
        [Theory]
        [InlineData(true, "The quick brown fox jumps over the lazy dog.")]
        public void IsPangram(bool expected, string str)
        {
            //Arrange
            Pangram pangram = new Pangram();

            //act
            bool result = pangram.IsPangram(str);

            //asserts
            Assert.Equal(expected, result);
        }
    }
}
