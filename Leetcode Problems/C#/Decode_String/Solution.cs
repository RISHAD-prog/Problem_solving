// See https://aka.ms/new-console-template for more information
public class Solution
{
    public string DecodeAtIndex(string s, int k)
    {
        string[] d = {};
        string c = "";
        var n = s; 
        IEnumerable<string> res ;
        for (int i = 0; i < s.Length; i++)
        {
            var sp = s[i];
            int v = 0;
            
            if (char.IsDigit(n, i))
            {
                v = (int)char.GetNumericValue(n[i]);
                var check = " ";
                d = n.Split(n[i]);
                c = String.Concat(Enumerable.Repeat(d[0], v));
                

                
            }
            
        }
        return d[k];
    }

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        var f = "leet2code3";
        var k = 10;

        var ans = s.DecodeAtIndex(f, k); 
        Console.WriteLine(ans);
    }
}