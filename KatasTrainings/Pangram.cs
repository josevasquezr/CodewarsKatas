using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

#region Intructions

//A pangram is a sentence that contains every single letter of the alphabet at least once. 
//For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, 
//because it uses the letters A-Z at least once (case is irrelevant).

//Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.

#endregion

namespace KatasTrainings
{
    public class Pangram
    {
        public bool IsPangram(string str)
        {
            Regex regex = new Regex(@"[a-z]|[A-Z]");
            var strList = str.ToList();

            var strListQuery = (
                                    from letter in strList
                                    where regex.IsMatch(letter.ToString())
                                    select letter.ToString().ToLower()
                               )
                               .Distinct()
                               .ToList();

            return strListQuery.Count() == 26;
        }
    }
}
