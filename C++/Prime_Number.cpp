#include<bits/stdc++.h>
using namespace std;
int chechPrimeNumber(int n)
{
     int i, m=0, flag=0;
  m=n/2;
  for(i = 2; i <= m; i++)
  {
      if(n % i == 0)
      {
          flag=1;
          break;
      }
  }
  if (flag==0)
    return 1;

}
int main()
{
    int first;
    int last;
    cin>>first;
    cin>>last;
        for(int i=first;i<last;i++)
        {
            int result=chechPrimeNumber(i);
            if(result==1)
            {
                cout<<i<<"="<<"prime"<<endl;
            }
            else{
                cout<<i<<"="<<"not prime"<<endl;;
            }
        }



}
