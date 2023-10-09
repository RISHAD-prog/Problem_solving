// See https://aka.ms/new-console-template for more information
public class Program
{
    public int MissingNumber(int[] nums)
    {
        var c = 0;
        var v = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (v > 0 && v == nums[j])
                {
                    c++;
                    break;
                }
                else if (nums[i] == nums[j] && i != j)
                {
                    c++;
                    v = nums[j];
                }

            }
            if (c == 0)
            {
                c = nums[j];
                break;
            }

        }
        return c;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        int[] n = { -1,-1,-2};
        var ans = program.MissingNumber(n);
        Console.WriteLine(ans);
    }
}
