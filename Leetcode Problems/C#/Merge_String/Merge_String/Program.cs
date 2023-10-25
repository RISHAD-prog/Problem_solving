using System;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        List<char> list = new List<char>();
        int count = 0;
        while (count < word1.Length || count <word2.Length) {
            if (count< word1.Length)
            {
                list.Add(word1[count]);
            }
            if(count< word2.Length)
            {
                list.Add(word2[count]);
            }
            
            count++;
        }
        var result = new string(list.ToArray());
        return result;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        string word1 = "ab";
        string word2 = "pqrs";
        var ans =  solution.MergeAlternately(word1, word2);
        Console.WriteLine(ans);
    }
}