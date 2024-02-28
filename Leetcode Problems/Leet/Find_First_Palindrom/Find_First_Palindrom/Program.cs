public class Solution
{
    public string FirstPalindrome(string[] words)
    {
        bool palindrome = false;
        foreach (var word in words)
        {
            int i = 0;
            int l = word.Length-1;
            while (i <= word.Length/2)
            {
                if (word[i] != word[l-i])
                {
                    palindrome = false;
                    break;
                }
                else
                {
                    palindrome = true;
                }
                i++;
            }
            if(palindrome == true)
            {
                return word;
            }
        }
        return "";
    }

    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] str = { "xngla", "e", "itrn", "y", "s", "pfp", "rfd" };
        var ans = solution.FirstPalindrome(str);
        Console.WriteLine(ans);
    }
}
