using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasTrainings
{
    public class Diamond
    {
        public string Print(int n)
        {
            string diamond = "";
            int[] diamondLevelNumber;
            int[] diamondSpaces;


            if (n <= 0 || (n % 2 == 0))
            {
                return null;
            }
            else if (n == 1)
            {
                return "*\n";
            }
            else
            {
                diamondLevelNumber = GetImparNumberDiamond(n);
                diamondSpaces = GetDiamondSpaces(n);
                for (int level = 0; level <= diamondLevelNumber.Length - 1; level++)
                {
                    diamond += GetSpaces(diamondSpaces[level]) + GetLevel(diamondLevelNumber[level]);
                }
            }

            return diamond;
        }

        private int[] GetDiamondSpaces(int n)
        {
            int cant = n / 2;
            List<int> spaces = new List<int>();

            if(cant > 0)
            {
                for(int i = cant; i > -1; i--)
                {
                    spaces.Add(i);
                }

                for (int i = 1; i <= cant; i++)
                {
                    spaces.Add(i);
                }
            }

            return spaces.ToArray();
        }

        private string GetLevel(int n)
        {
            return "".PadLeft(n, '*') + "\n";
        }

        private string GetSpaces(int n)
        {
            return "".PadLeft(n, ' ');
        }

        private int[] GetImparNumberDiamond(int n)
        {
            List<int> diamondMiddle = new List<int>();
            List<int> diamondReverse;

            for (int i = 1; i <= n; i++)
            {
                if(i%2 != 0)
                {
                    diamondMiddle.Add(i);
                }
            }

            diamondReverse = new List<int>(diamondMiddle);
            diamondReverse.RemoveAt(diamondMiddle.Count - 1);
            diamondReverse.Reverse();
            diamondMiddle.AddRange(diamondReverse);

            return diamondMiddle.ToArray();
        }
    }
}
