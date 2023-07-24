import java.util.*;
class roman_intejer {
	 public static  int romanToInt(String s) {
     char[] arr=new char[s.length()];
	   int i;
	   int I=1;int V=5;int X=10; int L=50; int C=100;int D=500;int M=1000; 
	   int sum=0;
	   for ( i=0;i<s.length();i++)
	   {
		arr[i]=s.charAt(i);
		if(arr[i]=='I')
		{
			if(arr[i+1]=='V')
			{ 
				sum=sum+V-I;
			}
			else if(arr[i+1]=='X')
			{
				sum=sum+X-I;
			}
			else
			{
				sum=sum+I;
			}
		}
		else if(arr[i]=='V')
		{
			sum=sum+V;
		}
		else if(arr[i]=='X')
		{
			if(arr[i+1]=='L')
			{ 
				sum=sum+L-X;
			}
			else if(arr[i+1]=='C')
			{
				sum=sum+C-X;
			}
			else
			{
				sum=sum+X;
			}
		}
		else if(arr[i]=='L')
		{
			sum=sum+L;
		}
		else if(arr[i]=='C')
		{
			if(arr[i+1]=='D')
			{ 
				sum=sum+D-C;
			}
			else if(arr[i+1]=='M')
			{
				sum=sum+M-C;
			}
			else
			{
				sum=sum+C;
			}
			
		}
		else if(arr[i]=='D')
		{
			sum=sum+D;
		}
		else if(arr[i]=='M')
		{
			sum=sum+M;
		}
		else
		{
			sum=0;
		}
		
	   }
		   return sum;
	    }

    


	public static void main(String[] args)
	{
		
		Scanner sc= new Scanner(System.in);
		System.out.println("S=");
		String input=sc.nextLine();
		int result=romanToInt(input);
		System.out.println(result);
	}
}
