namespace Valid_Anagram;
 public class Solution
{
  public bool IsAnagram(string s, string t)
{
   if(s.Length != t.Length)
   {
    return false;
   }
   int[] count  = new int[26];
   for(int i =0; i<s.Length; i++)
   {
    count[s[i] - 'a']++;
    count[t[i] - 'a']--;
   }
   for(int i =0; i<26; i++)
   {
    if(count[i] != 0)
    {
        return false;
    }
   }
   return true;
}

}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // Output: True
        Console.WriteLine(solution.IsAnagram("rat", "car")); // Output: False
    }
}
