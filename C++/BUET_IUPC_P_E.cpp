#include<bits/stdc++.h>
using namespace std;
int coffee(int arr[],int l,int m,int n)
{
    if(m>=l)
        {
           int mid = l + (m-l)  / 2 ;
           if(arr[mid]==n)
           {
               return mid;
           }
           if(arr[mid]>n)
           {
               return coffee(arr,l,mid - 1,n);
           }
           else{
            return coffee(arr,mid - 1,m,n);
           }
        }

}

int main()
{
    int n,m;
    int store;
    int arr[1000];
    cin>>n;
    cin>>m;
    for (int i=0;i<m;i++)
    {
        cin>>arr[i];

    }
    m=sizeof(arr) / sizeof(arr[0]);
    int result=coffee(arr,0,m-1,n);
    cout<<result;
}
