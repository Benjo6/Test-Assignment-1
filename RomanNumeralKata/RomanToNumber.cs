using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    public class RomanToNumber
    {
        public int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDict = new()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                foreach (char c in s)
                {
                    if (!romanNumbersDict.ContainsKey(c))
                        throw new ArgumentException($"Invalid Character: {c}");
                }
                char currentRomanChar = s[i];

                romanNumbersDict.TryGetValue(currentRomanChar, out int number);
                if (i + 1 < s.Length && romanNumbersDict[s[i + 1]] > romanNumbersDict[currentRomanChar])
                    sum -= number;
                else
                    sum += number;
            }
            return sum;
        }

    }
}
