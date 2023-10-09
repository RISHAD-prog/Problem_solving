// See https://aka.ms/new-console-template for more information
public class Program
{
    public int[] SearchRange(int[] nums, int target)
    {
        int i = 0;
        List<int> list = new List<int>();
        int[] ans = new int[2];
        foreach (int item in nums)
        {
            if (item == target)
            {
                list.Add(i);
            }
            
            i++;
        }
        if (list.Count!=0)
        {
            ans[0] = (list[0]);
            ans[1] = (list[list.Count - 1]);
        }
        else
        {
            ans[0] = -1;
            ans[1] = -1;
        }
        return ans;
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        int[] nums = {  };
        int target = 0;
        var ans=program.SearchRange(nums, target);
        foreach (var item in ans)
        {
            Console.WriteLine(item);
        }
        
    }
}
