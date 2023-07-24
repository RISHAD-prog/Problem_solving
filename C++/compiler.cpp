#include<bits/stdc++.h>
using namespace std;
int main()
{
    int j;
    cout<<"Enter the length of array: ";
    cin>>j;
    int number[j];

    cout<<" Enter the elements: " ;
    for (int i=0; i<j; i++)
    {
        cin>>number[i];

    }
    cout<<"Normal:";
    for (int i=0; i<10; i++)
    {
        cout<<number[i] <<" " ;

    }
    cout<<"Reverse:";
    for (int i=j-1; i>=0; i--)
    {
        cout<<number[i] <<" " ;

    }

}
