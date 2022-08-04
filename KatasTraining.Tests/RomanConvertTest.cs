using KatasTrainings;

namespace KatasTraining.Tests
{
    public class RomanConvertTest
    {
        [Theory]
		[InlineData(1, "I")]
		[InlineData(2, "II")]
		[InlineData(4, "IV")]
		[InlineData(500, "D")]
		[InlineData(1000, "M")]
		[InlineData(1954, "MCMLIV")]
		[InlineData(1990, "MCMXC")]
		[InlineData(2008, "MMVIII")]
		[InlineData(2014, "MMXIV")]
		public void Solution(int number, string expected)
        {
			//arrange
			RomanConvert romanConvert = new RomanConvert();
			string result = "";

			//act
			result = romanConvert.Solution(number);

			//Asserts
			Assert.Equal(expected, result);
        }
	}
}
