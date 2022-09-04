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

            var numberCountGroup = dice.GroupBy(n => n)
                                        .Select(g => new { num = g.Key, count = g.Count() })
                                        .ToList();

            foreach (var tup in numberCountGroup)
            {
                switch (tup.count)
                {
                    case 1: case 2:
                        score += GetOneValue().GetValueOrDefault(tup.num, 0) * tup.count;
                        break;
                    case 3:
                        score += GetThreeValue().GetValueOrDefault(tup.num, 0);
                        break;
                    case 4:
                        score += GetThreeValue().GetValueOrDefault(tup.num, 0);
                        score += GetOneValue().GetValueOrDefault(tup.num, 0);
                        break;
                    case 5:
                        score += GetThreeValue().GetValueOrDefault(tup.num, 0);
                        score += GetOneValue().GetValueOrDefault(tup.num, 0) * 2;
                        break;
                    default:
                        break;
                }
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
