// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        var occ = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]%2 == 0)
            {
                var temp = nums[occ];
                nums[occ] = nums[i];
                nums[i] = temp;
                occ++;
            }
        }
        return nums;
    }

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int[] nums= { 3, 1, 2, 4 };
        var ans = s.SortArrayByParity(nums);
        foreach (var item in ans)
        {
            Console.WriteLine(item);
        }
        
    }
}
