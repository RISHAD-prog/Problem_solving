using System.Collections;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();


        foreach (var num in nums)
        {
            if (!dictionary.ContainsKey(num))
            {
                dictionary.Add(num, 1);
            }
            else
            {           
                dictionary[num]++;
            }

            if (dictionary[num] > nums.Length/2) {
                return num;
            }
        }
        return 0;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 2, 2, 1, 1, 1, 2, 2};
        var ans = solution.MajorityElement(nums);
        Console.WriteLine(ans); 
    }
}
