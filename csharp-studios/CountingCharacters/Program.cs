using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string crazyString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. " +
                                 "Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. " +
                                 "Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> countingDict = new Dictionary<char, int>();

            for (int i = 0; i <= crazyString.Length - 1; i++)
            {
                if (!countingDict.ContainsKey(crazyString[i]))
                {
                    countingDict.Add(crazyString[i], 1);
                } else
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
