public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {

    }
    static void main(string[] args)
    {
        Solution solution = new Solution();
        string[] words = { "cat", "bt", "hat", "tree"};
        string chars = "atach";
        var ans = solution.CountCharacters(words, chars);
        Console.WriteLine(ans);
    }
}
