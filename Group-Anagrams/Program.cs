using System.Text;

namespace Group_Anagrams;
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 0)
        {
            return new List<IList<string>>();
        }

        Dictionary<string, List<string>> ansMap = new Dictionary<string, List<string>>();
        int[] count = new int[26];

        foreach (string s in strs)
        {
            Array.Fill(count, 0);
            foreach (char c in s)
            {
                count[c - 'a']++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                sb.Append("#");
                sb.Append(count[i]);
            }

            string key = sb.ToString();
            if (!ansMap.ContainsKey(key))
            {
                ansMap[key] = new List<string>();
            }
            ansMap[key].Add(s);
        }

        return new List<IList<string>>(ansMap.Values);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        IList<IList<string>> result = solution.GroupAnagrams(strs);
        foreach (var group in result)
        {
            Console.WriteLine(string.Join(", ", group));
        }
    }
}
