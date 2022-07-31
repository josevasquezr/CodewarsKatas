using KatasTrainings;
using System.Collections;

namespace KatasTraining.Tests
{
    public class CountCharactersInStringTest
    {
        [Theory]
        [ClassData(typeof(CountCharactersInStringClassData))]
        public void Count(Dictionary<char, int> expected, string text)
        {
            //arrange
            CountCharactersInString countCharactersInString = new CountCharactersInString();
            Dictionary<char, int> result = new Dictionary<char, int>();

            //act
            result = countCharactersInString.Count(text);

            //asserts
            Assert.Equal(expected, result);
        }
    }

    public class CountCharactersInStringClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Dictionary<char, int>() { { 'a', 6 } }, "aaaaaa" };
            yield return new object[] { new Dictionary<char, int>() { }, "" };
            yield return new object[] { new Dictionary<char, int>() { { 'a', 2 }, { 'b', 2 }, { 'c', 2 } }, "aabbcc" };
            yield return new object[] { new Dictionary<char, int>() { { 'J', 2 }, { 'o', 1 }, { 's', 1 }, { 'e', 2 }, { ' ', 1 }, { 'a', 1 }, { 'v', 1 }, { 'i', 1 }, { 'r', 1 } }, "Jose Javier" };
            yield return new object[] { new Dictionary<char, int>() { { '6', 3 } }, "666" };
            yield return new object[] { new Dictionary<char, int>() { { 'o', 2 }, { 'l', 2 }, { 'e', 2 } }, "oleole" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
