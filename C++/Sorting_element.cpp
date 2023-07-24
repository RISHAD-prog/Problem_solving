#include<bits/stdc++.h>
using namespace std;
void Swap(int *p,int *q)
{
    int temp=*p;
    *p=*q;
    *q=temp;
}
void printArray(int arr[], int n)
{
 int i;
 for (i=0; i < n; i++)
 cout<<arr[i]<<" ";
 cout<<endl;
}
int main()
{
    int Size;
    cin>>Size;
    int arr[Size]={12,11,13,5,6};


    for(int i=0; i<Size; i++)
    {
        for(int j=i+1;j<Size;j++)
        {
                if(arr[j]<arr[i])
                {
                    Swap(&arr[i], &arr[j]);
                }
        }


    }

    printArray(arr,Size);
}
