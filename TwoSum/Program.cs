namespace TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
          int[] sortedNums = (int[])nums.Clone();
        
        // Sort the array while keeping track of the original indices
        Array.Sort(sortedNums);
        
        int left = 0;
        int right = sortedNums.Length - 1;


        while (left < right)
        {
            int sum = sortedNums[left] + sortedNums[right];
            if (sum == target)
            {
                // Find the original indices of the two numbers
                int index1 = Array.IndexOf(nums, sortedNums[left]);
                int index2 = Array.IndexOf(nums, sortedNums[right]);
                
                // Handle the case where the two numbers are the same
                if (index1 == index2)
                {
                    index2 = Array.LastIndexOf(nums, sortedNums[right]);
                }
                
                return new int[] { index1 , index2  };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        // If no solution is found, return an empty array or throw an exception
        return new int[0];
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}
