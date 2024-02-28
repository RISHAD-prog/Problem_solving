public class Solution
{
    public void InsertionSort(int[] arr)
    {

        for (int i = 1; i < arr.Length; i++)
        {
            var key = arr[i];
            var k = i - 1;
            while (k >= 0 && arr[k] > key)
            {
                var temp = arr[k];
                arr[k] = key;
                arr[k+1] = temp;
                key = arr[k];
                k--;
            }
        }
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = { 9, 5, 1, 4, 3 };
        solution.InsertionSort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);  
        }
    }
}

