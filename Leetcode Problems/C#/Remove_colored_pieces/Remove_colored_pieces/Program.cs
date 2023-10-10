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
            if (colors[i] == 'A')
            {
                if (i+1 < colors.Length && i+2<colors.Length)
                {
                    if (colors[i + 1] == 'A' && colors[i + 2] == 'A')
                    {
                        a++;
                        i = i + 1;
                        afirst = i;
                    }
                }
                
                
            }
            else
            {
                if (i + 1 < colors.Length && i + 2 < colors.Length)
                {
                    if (colors[i + 1] == 'B' && colors[i + 2] == 'B')
                    {
                        b++;
                        i = i + 1;
                        bfirst = i;
                    }
                }
                   
                
            }

        }
        
            if (a > b )
            {
                return true;
            }
            else if(a == b)
            {
                if(afirst < bfirst)
                {
                    return true;
                }
                else { return false; }
            }
        
        
        return false;
        
    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        string colors = "AAAABBBB";
        var ans = p.WinnerOfGame(colors);
        Console.WriteLine(ans);
    }
}
