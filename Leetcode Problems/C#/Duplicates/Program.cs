// See https://aka.ms/new-console-template for more information
using System.Collections;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);
        var mid = nums.Length / 2;
        if(nums.Length )
        for (int i = 0; i < mid; i++)
        {
            
        }
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 2, 3 };
        var ans = solution.ContainsDuplicate(nums);
        Console.WriteLine(ans);
    }
}