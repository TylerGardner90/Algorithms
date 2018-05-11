using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorials
{
    public class StringAlgorithms
    {
        public StringAlgorithms() { }

        public bool IsAnagram(string test1, string test2)
        {
            Dictionary<char, int> dict1 = StringToDict(test1);
            Dictionary<char, int> dict2 = StringToDict(test2);

            if (dict1.Count == dict2.Count)
            {
                foreach (KeyValuePair<char,int> kvp in dict1)
                {
                    if (!dict2.ContainsKey(kvp.Key) || dict2[kvp.Key] != kvp.Value)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private Dictionary<char, int> StringToDict(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            foreach (char c in s.ToUpper().ToCharArray().Where(c => !char.IsPunctuation(c)).ToArray())
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            return dict;
        }
    }
}