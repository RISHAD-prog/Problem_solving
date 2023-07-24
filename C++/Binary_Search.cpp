#include <bits/stdc++.h>
using namespace std;

int Qualified_Student(int arr[], int l, int r, int x)
{
    if (r >=l) {
        int mid = l + (r-l)  / 2 ;

        if (arr[mid] == x)
        {
             return x;
        }


        if (arr[mid] > x)
           {
               return Qualified_Student(arr, l, mid - 1, x);
           }

        else{
                return Qualified_Student(arr, mid + 1, r, x);
        }
    }


    return -1;
}

int main(void)
{

    int arr[] = { 60, 70, 80, 90, 100 };
    int x ;
    cin>>x;
    int n = sizeof(arr) / sizeof(arr[0]);
    int result = Qualified_Student(arr, 0, n-1, x);
    if(result==-1)
    {
        cout << "Failed";
    }
    else{
        if(x==90 || x==100)
        {
            cout<<"A+";
        }
        else if(x==80)
        {
            cout<<"A";
        }
        else if(x==70)
        {
            cout<<"B+";
        }
         else if(x==60)
        {
            cout<<"B";
        }
    }
}


