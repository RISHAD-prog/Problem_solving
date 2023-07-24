#include<bits/stdc++.h>
using namespace std;
int main()
{
    static int T;
    int size;
    cout<<"Enter the size :";
    cin>>size;
    int arr[size];
    int N;
    cout<<"Enter the elements:";
    for(int i=0;i<size;i++)
    {
        cin>>N;
        arr[i]=N;
        if(arr[i]%2==0)
        {
            T=0;

        }
        else
        {
            T=1;

        }


    }
   for(int i=0;i<size;i++)
   {

    switch(T)
    {
    case 0:
        cout<<"Even";
        break;
    case 1:
        cout<<"Odd";
        break;
    default:
        cout<<"No suitable output";
        break;

    }
   }


return 0;
}
