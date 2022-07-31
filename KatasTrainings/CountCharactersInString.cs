namespace KatasTrainings
{
    public class CountCharactersInString
    {
        public Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> counterMap = new Dictionary<char, int>();

            foreach (char character in str.ToCharArray())
            {
                if (!counterMap.ContainsKey(character))
                {
                    counterMap.Add(character, str.Count(c => c == character));
                }
            }

            return counterMap;
        }
    }
}
