public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var data = s.Split(' ');
        var v = "";
        int i = 1;
        while (v == "")
        {
            v = data[data.Length - i];
            i++;
        }
        return v.Length;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string s = "luffy is still joyboy";
        var ans = solution.LengthOfLastWord(s);
        Console.WriteLine(ans);
    }   
}