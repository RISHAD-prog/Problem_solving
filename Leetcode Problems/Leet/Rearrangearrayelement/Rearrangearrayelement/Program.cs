public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        int[] result = new int[nums.Length];
        int posindex = 0;
        int negindex = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= 0 )
            {
                result[posindex] = nums[i];
                posindex+=2;
            }
            else {

                result[negindex] = nums[i];
                negindex+=2;
            }
        }
        return result;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = { 3, 1, -2, -5, 2, -4 };
        var ans= solution.RearrangeArray(arr);
        foreach (var item in ans)
        {
            Console.WriteLine(item);          
        }
    }
}
