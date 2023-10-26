public class Solution
{
    public int PivotIndex(int[] nums)
    {

        int SumLeft = 0;
        int SumRight = nums.Sum() - nums[0];
        if (SumLeft == SumRight)
            return 0;
        for (int i = 1; i <= nums.Length - 1; i++)
        {
            SumLeft += nums[i];
            SumRight -= nums[nums.Length - i];
            if(SumRight == SumLeft) 
                return i ;
        }
        return -1;
            
    }
    
  
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 1, 7, 3, 6, 5, 6 };
        var ans = solution.PivotIndex(nums);
        Console.WriteLine(ans);
    }
}