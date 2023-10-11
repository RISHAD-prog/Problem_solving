public class Program
{
    public bool WinnerOfGame(string colors)
    {
        int a = 0;
        int b = 0;
        var afirst = 0;
        var bfirst = 0;
        for (int i = 0; i < colors.Length; i++)
        {
            if (i + 1 < colors.Length && i + 2 < colors.Length)
            {
                if (colors[i + 1] == 'A')
                {
                    if (colors[i] == 'A' && colors[i + 2] == 'A')
                    {
                        a++;

                        afirst = i;
                    }
                }
                else
                {
                    if (colors[i] == 'B' && colors[i + 2] == 'B')
                    {
                        b++;

                        bfirst = i;
                    }
                }
            }
                

        }
        
            if (a > b )
            {
                return true;
            }
           /* else if(a == b)
            {
                if(afirst < bfirst)
                {
                    return true;
                }
                else { return false; }
            }*/
        
        
        return false;
        
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        string colors = "ABBBBBBBAAA";
        var ans = p.WinnerOfGame(colors);
        Console.WriteLine(ans);
    }
}
