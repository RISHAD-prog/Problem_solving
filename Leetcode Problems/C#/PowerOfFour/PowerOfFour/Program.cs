
public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        var i = Math.Log(n) / Math.Log(4);
        i = Math.Truncate(i);
        if (n > 0)
        {
            if ( Math.Pow(4,i) == n || n == 1)
            {
                return true;
            }
        }
        
        return false;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int n = 256;
        var ans = solution.IsPowerOfFour(n);
        Console.WriteLine(ans);
    }
}