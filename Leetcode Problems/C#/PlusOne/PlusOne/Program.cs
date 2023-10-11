using System.Linq;
using System.Numerics;

public class Program
{
    public int[] PlusOne(int[] digits)
    {
        string[] s = Array.ConvertAll(digits, x => x.ToString());
        var s1 = String.Join("", s);
        BigInteger number = BigInteger.Parse(s1);
        number++;
        string result = number.ToString();
        int[] arr = result.Select( c => int.Parse(c.ToString())).ToArray();
        return arr;
        /*char[] intList = {};
        digits[digits.Length - 1] = v+1;
            
            intList = s.ToCharArray();
            int[] n = new int[intList.Length];*/
            
           
        
        
       // return n;
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        int[] digits = { 9 };
        var ans = program.PlusOne(digits);
        foreach (var item in ans)
        {
            Console.WriteLine(item);
        }
        
    }
}
