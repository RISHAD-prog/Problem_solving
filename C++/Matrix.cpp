#include<bits/stdc++.h>
using namespace std;
int main()
{
    int i,j,m;
    cout<<"Enter the length of row: ";
    cin>>i;
    cout<<"Enter the length of column: ";
    cin>>j;
    int arr1[i][j];
    int arr2[i][j];
    int arr3[i][j];
    int newarr[i][j];
    cout<<"Enter the 1st array element: ";

    for(int k=0;k<i;k++)
        {
          for (int l=0;l<j;l++)
          {
            cin>>arr1[k][l];
          }
        }
        cout<<"Enter the 2nd array element: ";
         for(int k=0;k<i;k++)
        {
          for (int l=0;l<j;l++)
          {
            cin>>arr2[k][l];
          }
        }
    cout<<"Enter the 3rd array element: ";
    for(int k=0;k<i;k++)
        {
          for (int l=0;l<j;l++)
          {
            cin>>arr3[k][l];
          }
        }
    cout<<"Matrix :" <<endl;

        for(int k=0;k<i;k++)
        {
            for (int l=0;l<j;l++)
            {
                newarr[k][l]=arr1[k][l]+arr2[k][l]+arr3[k][l];
                cout<<newarr[k][l]<<" ";
            }
            cout<<endl;
        }

}
