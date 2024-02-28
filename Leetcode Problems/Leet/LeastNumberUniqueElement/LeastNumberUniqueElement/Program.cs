public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!dictionary.ContainsKey(arr[i])) {
                dictionary.Add(arr[i], 1);
            }
            else
            {
                dictionary[arr[i]]++;
            }
            
            
        }
        var d = dictionary.OrderBy(x => x.Value).ToDictionary(x=>x.Key, x=>x.Value);
        var a = dictionary.Values;
        var j = 0;
        
        while (j <= k )
        {
            var sum = 0;
            sum = sum+ d[j];
        }

        return k;
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = { 4, 3, 1, 1, 3, 3, 2 };
        int k = 3;
        var ans = solution.FindLeastNumOfUniqueInts(arr, k);
        Console.WriteLine(ans);
    }
}
