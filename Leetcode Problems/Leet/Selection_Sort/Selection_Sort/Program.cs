public class solution
{
    public void Selectionsort(int[] arr)
    {
        
        for (int j = 0; j < arr.Length-1; j++)
        {
            var minimum = j;
            for (int i = j+1; i < arr.Length; i++)
            {
                if (arr[minimum] > arr[i])
                {
                   minimum = i;
                }
            }
            var temp = arr[j];
            arr[j] = arr[minimum];
            arr[minimum] = temp;
        }
        
    }
    public static void Main(string[] args)
    {
        solution solution = new solution();
        int[] arr = { 20, 12,2,10,15 };
        solution.Selectionsort(arr);
        foreach (var data in arr)
        {
            Console.WriteLine(data);
        }
        
    }
}
