namespace Longest_Consecutive_Sequence;

public class Solution {
   public int LongestConsecutive(int[] nums) {
    if (nums == null || nums.Length == 0) {
        return 0;
    }
    
    HashSet<int> numSet = new HashSet<int>(nums);
    int longestSequence = 0;

    foreach (int num in numSet) {
        // Only check if `num` is the start of a sequence
        if (!numSet.Contains(num - 1)) {
            int currentNum = num;
            int currentStreak = 1;

            // Keep counting consecutive numbers
            while (numSet.Contains(currentNum + 1)) {
                currentNum++;
                currentStreak++;
            }

            longestSequence = Math.Max(longestSequence, currentStreak);
        }
    }

    return longestSequence;
}

}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = {100, 4, 200, 1, 3, 2};
        int result = solution.LongestConsecutive(nums);
        Console.WriteLine(result);  // Output: 4
    }
}
