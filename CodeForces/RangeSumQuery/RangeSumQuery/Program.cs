class Program
{
    public int getValues(int L, int R, int[] arr) {
        int sum = 0;
        for (int j = L-1; j < R; j++)
        {
            sum += (int)arr[j];
        }
        return sum;
    }
    static void Main(String[] args)
    {
        Program program = new Program();
        var in1 = Console.ReadLine();
        var in2 = in1.Split(' ');
        int N= int.Parse(in2[0]);
        int Q= int.Parse(in2[1]);
        var stringArray = Console.ReadLine().Split(' ');
        int[] qarr= new int[Q*2];
        int index = 0;
        var arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(stringArray[i]);
        }

        for (int i = 0; i < Q; i++)
        {
            var in3 = Console.ReadLine();
            var in4 = in3.Split(' ');
            int L = int.Parse(in4[0]);
            int R = int.Parse(in4[1]);
            qarr[index] = L;
            qarr[index+1] = R;
            index += 2;
        }
        for (int i = 0; i < Q*2; i = i+2)
        {
            var ans = program.getValues(qarr[i], qarr[i + 1], arr);
            Console.WriteLine(ans);
        }
    }
}
