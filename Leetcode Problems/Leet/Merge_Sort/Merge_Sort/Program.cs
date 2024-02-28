public class Solution
{
    public void MergeSort(int[] arr, int f, int m, int l)
    {
        int n1 = m - f + 1;
        int n2 = l - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[f + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];
        i = 0;
        j = 0;

    
        int k = f;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }

    }
    public void sort(int[] arr, int f, int l)
    {
        if (f < l)
        {
            int m = f + (l - f) / 2;
            sort(arr, f, m);
            sort(arr, m + 1, l);

            MergeSort(arr, f, m, l);
        }
        
    }
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = { 6, 5, 12, 10, 9, 1};
        solution.sort(arr, 0, arr.Length-1);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}