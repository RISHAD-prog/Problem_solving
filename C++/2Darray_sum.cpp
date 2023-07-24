#include<bits/stdc++.h>
using namespace std;
int main()
{
    int sum=0;
    int arr[4][5];
    for(int i=0;i<4;i++)
    {
        for(int j=0;j<5;j++)
        {
            cin>>arr[i][j];
        }
    }
     for(int i=0;i<4;i++)
    {
        for(int j=0;j<5;j++)
        {
            if(i>0 && i<3)
            {
                if(j>=1&&j<4)
                {
                    sum=sum+arr[i][j];
                }
            }
        }
    }
    cout<<sum;
}
