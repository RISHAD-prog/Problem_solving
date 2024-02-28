public class solution
{
    public void bubbleSort(int[] arr)
    {
        
        for (int i = 0; i < arr.Length-1; i++)
        {
            var swap = false;
            for (int j = 0; j < arr.Length-i -1; j++)
            {
                
                if (arr[j] > arr[j+1])
                {
                   var temp = arr[j]; 
                   arr[j] = arr[j+1]; 
                   arr[j+1] = temp;
                   swap = true;
                }
            }
            if(swap == false)
            {
                return;
            }
        }
    }
    public static void Main(string[] args)
    {
        solution solution = new solution();
        int[] data = { -2, 45, 0, 11, -9 };
        solution.bubbleSort(data);
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}