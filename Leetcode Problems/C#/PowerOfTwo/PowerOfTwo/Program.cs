public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        var i = Math.Log(n) / Math.Log(2);
        i = Math.Truncate(i);
        if (n > 0)
        {
            if (Math.Pow(2, i) == n || n == 1)
            {
                return true;
            }
        }

        return false;
    }
}