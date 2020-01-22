using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string crazyString = Console.ReadLine().ToLower();

            Dictionary<char, int> countingDict = new Dictionary<char, int>();

            for (int i = 0; i <= crazyString.Length - 1; i++)
            {
                if (!countingDict.ContainsKey(crazyString[i]))
                {
                    countingDict.Add(crazyString[i], 1);
                } 
                else
                {
                    countingDict[crazyString[i]] += 1;
                }

            }

            foreach (KeyValuePair<char, int> keyValuePair in countingDict)
            {
                Console.WriteLine(keyValuePair.Key.ToString() + ": " + keyValuePair.Value.ToString());
            }
        }
    }
}
