#include<bits/stdc++.h>
using namespace std;
int main()
{
    // code here
    int N=100;

    cout<<"N:";
    cin>>N;
    int A[N];
    cout<<"Enter the values :";
    for(int i=0; i<N; i++)
    {
        cin>> A[i];
    }
    for(int i=0; i<N; i++)
    {

        if(A[i]%2!=0)
        {
            cout<<A[i]<<" ";
        }
    }

}
