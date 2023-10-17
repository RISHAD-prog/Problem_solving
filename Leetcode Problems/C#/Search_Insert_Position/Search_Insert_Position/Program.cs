public class Program
{
    public int SearchInsert(int[] nums, int target)
    {
        int l =0;int h = nums.Length-1;
        int mid;
        while(l <= h)
        {
            mid = l + (h - l) / 2;
            if (target < nums[mid])
            {
                h = mid-1;
            }
            else if (target > nums[mid])
            {
                l = mid + 1;
            }
            else
            {
                return mid;
            }
           
        }

        return l;
    }
    public static void Main(String[] args)
    {
        Program program = new Program();
        int[] nums = { 1, 2, 3, 4, 5 };
        int target = 0;
        var ans = program.SearchInsert(nums, target);   
        Console.WriteLine(ans); 
    }
}
