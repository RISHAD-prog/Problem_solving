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
           
           
               sum=sum+I;
           
       }
       else if(arr[i]=='V')
       {
            if(arr[i-1]=='I')
            { 
                sum=sum+V-I;
                i++;
            }
            else{
                 sum=sum+V;
                }
          
       }
       else if(arr[i]=='X')
       {
            if(arr[i-1]=='I')
            { 
                sum=sum+X-I;
                i++;
            }
            else
            {
                sum=sum+X;
            }
            
           
          
       }
       
       else if(arr[i]=='L')
       {
            if(arr[i-1]=='X')
            { 
                sum=sum+L-X;
                i++;
            }
            else
            {
                sum=sum+L;
            }
           
       }
       else if(arr[i]=='C')
       {
            if(arr[i-1]=='X')
            { 
                sum=sum+C-X;
                i++;
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