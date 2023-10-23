public class Solution
{
    public int HammingWeight(uint n)
    {
        int i = 0;
        int j = 0;
        string s = n.ToString();
        while (i < s.Length)
        {
            if (s[i] ==  '1')
            {
                j ++;
            }
            i++;
        }
        return j;
    }
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        uint n = 00000000000000000000000000001000;
        var ans = s.HammingWeight(n);
        Console.WriteLine(ans);
    }
}