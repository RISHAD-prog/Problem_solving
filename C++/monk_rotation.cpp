#include<bits/stdc++.h>
using namespace std;
int main()
{
    int test_case,n,k,l;
    int arr[20];
    cin>>test_case;
    for(int i=0;i<test_case;i++)
    {
        cin>>n;

        cin>>k;
        for(int j=0;j<n;j++)
        {
            cin>>arr[j];

        }
        for(int j=0;j<n;j++)
        {
            l=1;
            while(l<=k)
            {
                arr[j]=arr[n-l];
                arr[n-l]=arr[n+l];
                l++;
            }
            cout<<arr[j];
        }
    }
}
