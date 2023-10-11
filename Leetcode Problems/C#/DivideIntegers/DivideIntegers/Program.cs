using System.Numerics;

public class Program
{
    public int Divide(int dividend, int divisor)
    {
        long dividendLong = dividend;
        long divisorLong = divisor;

        long result = dividendLong / divisorLong;

        if (result > int.MaxValue || result < int.MinValue)
        {
            return result > 0 ? int.MaxValue : int.MinValue;
        }

        return (int)result;
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        int dividend = 7; 
        int divisor = -3;
        var ans = program.Divide(dividend, divisor);
        Console.WriteLine(ans);
    }
}