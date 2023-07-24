#include<bits/stdc++.h>
using namespace std;
int main()
{
    int s;
    int c=0;
    int problem=0;
    cin>>s;
    int num[s][3];
    for(int i=0;i<s;i++)
       {
           for(int j=0;j<3;j++)
           {
               cin>>num[i][j];

           }

       }
         for(int i=0;i<s;i++)
       {
           for(int j=0;j<3;j++)
           {
               if(num[i][j]==1)
                {
                    c++;

                }

           }
           if(c>1)
                    {
                       problem++;
                    }
                c=0;

       }
       cout<<problem;

}
