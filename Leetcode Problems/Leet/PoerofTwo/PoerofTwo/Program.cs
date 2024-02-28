public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        var i = Math.Log(n) / Math.Log(2);

        if (n == i)
        {
            return true;
        }
        return false;
    }
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        int n = 16;
        var ans = s.IsPowerOfTwo(n);
        Console.WriteLine(ans);
    }
}
