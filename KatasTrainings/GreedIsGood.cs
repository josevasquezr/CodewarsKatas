using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTrainings
{
    public class GreedIsGood
    {
        public int Score(int[] dice)
        {
            int score = 0;
            List<int> diceCopy = dice.ToList();
            List<int> threeValueDices = new List<int>();

            foreach (int numr in dice)
            {
                int count = dice.Where(n => n == numr).Select(n => n).Count();

                if (count >= 3 && !threeValueDices.Contains(numr))
                {
                    for(int i = 0; i < 3; i++)
                    {
                        diceCopy.Remove(numr);
                    }
                    threeValueDices.Add(numr);
                }
            }

            foreach(int threeVal in threeValueDices)
            {
                score += GetThreeValue().GetValueOrDefault(threeVal);
            }

            foreach (int oneVal in diceCopy)
            {
                score += GetOneValue().GetValueOrDefault(oneVal);
            }

            return score;
        }

        private Dictionary<int, int> GetThreeValue()
        {
            return new Dictionary<int, int>()
            {
                {1, 1000},
                {6, 600},
                {5, 500},
                {4, 400},
                {3, 300},
                {2, 200}
            };
        }

        private Dictionary<int, int> GetOneValue()
        {
            return new Dictionary<int, int>()
            {
                {1, 100},
                {5, 50}
            };
        }
    }
}
