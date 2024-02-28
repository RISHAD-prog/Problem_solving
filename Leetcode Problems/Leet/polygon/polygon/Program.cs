public class Solution
{
    public long LargestPerimeter(int[] nums)
    {
        int prevElementSum = 0;
        Array.Sort(nums);
        var ans = -1;
        for (int j = 0; j < nums.Length; j++)
        {
            
            if (prevElementSum > nums[j])
            {
                ans = prevElementSum + nums[j] ;
            }
            prevElementSum += nums[j];
        }
        return ans;

    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = { 5, 5, 50 };
        var ans = solution.LargestPerimeter(arr);
        Console.WriteLine(ans);
    }
}