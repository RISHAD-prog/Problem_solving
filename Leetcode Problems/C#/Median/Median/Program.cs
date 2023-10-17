public class Program
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] result = nums1.Concat(nums2).ToArray();
        Array.Sort(result);
        double median = 0.00000;
        if (result.Length%2 != 0)
        {
            median = result[(result.Length) / 2] ;
        }
        else
        {
            median = result[(result.Length-1)/2] + result[((result.Length-1)/2)+1] ;
            median = median / 2;
        }
        return median; 
    }
    public static void Main(String[] args)
    {
        Program program = new Program();
        int[] nums1 = {2 };
        int[] nums2 = {  };
        double ans = program.FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine(ans);
    }
}