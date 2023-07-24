#include<iostream>
using namespace std;
int main()
{
   int n, i, c = 0, f=1;

   cout << "Enter the number: ";
   cin >> n;
   for (i=1; i<=n; i++)
   {
      if ((n% i) == 0)
      {
         c++;
      }
   }

   if (c == 2)
       {
       for(int x=1;x<=n;x++)
        {
            f*=x;
        }
       cout << "Factorial= " << f;
   }

   else
    {
       cout << "Error!Not a prime number";
    }

   return 0;
}



