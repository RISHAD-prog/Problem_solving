// See https://aka.ms/new-console-template for more information
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        var ans = false;
        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] >= nums[i+1] )
            {
                ans = true;
            }
            else
            {
                ans = false;
            }
        }
        return ans;
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1,3,2 };
        var ans = solution.IsMonotonic(nums);
        Console.WriteLine(ans);
    }
}