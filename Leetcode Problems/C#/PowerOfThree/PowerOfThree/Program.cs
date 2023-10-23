public class Solution
{
    public bool IsPowerOfThree(int n)
    {
        var i = Math.Log(n) / Math.Log(3);
        i = Math.Ceiling(i);
        if (n > 0)
        {
            if (Math.Pow(3, i) == n || n == 1)
            {
                return true;
            }
        }

        return false;
    }
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int n = 243;
        var ans = s.IsPowerOfThree(n);
        Console.WriteLine(ans);
    }
}