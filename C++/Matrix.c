#include<bits/stdc++.h>
using namespace std;
int main()
{
    int i,j;
    cout<<"Enter the length of row: ";
    cin>>i;
    cout<<"Enter the length of column: ";
    cin>>j;
    int arr[i][j];

    for(int k=0;k<i;k++)
    {
        for (int l=0;l<j;l++)
        {
            cout<<arr[k][l]<<" ";
        }
    }
}
