public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int i = 0;
        int j = trust[0][1];
        int value = 0;
        dictionary.Add(j, value);
        foreach (var item in trust)
        {
            
            if (j != item[0] || dictionary.ContainsKey(item[1]))
            {
                j = item[1];
                dictionary[j] = value++;
                
            }
            else
            {
                j = item[1];
                value = 0;
                dictionary.Add(j, value);
            }
            

            if(j == item[0])
            {
                j = item[0];
            }
            j = item[1];

            i++;
        }
        return j;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] ints = { [1, 3], [1, 4], [2, 3], [2, 4], [4, 3] };
        int n = 3;
        var ans = solution.FindJudge(n, ints);
        Console.WriteLine(ans);
    }
}
