#include<bits/stdc++.h>
using namespace std;
int main()
{
    int i,c,num;
    int j=0;
    bool check=true;
    int sum=0;
    cin>>num;
    int arr1[num];
    int arr2[num];
    int arr3[num];
    for(i=0;i<num;i++)
    {
        cin>>arr1[i];

        cin>>arr2[i];

        if(arr1[i]!=num)
            {
                 j=1;
                arr3[i]=arr1[i];
                while(arr1[i]>num)
                {

                    arr1[i]=arr3[i]-arr2[i]*j;
                     j++;
                    sum++;

                }
                if(arr1[i]==num)
                {
                    check=false;
                }

            }


        }
        if(check==false)
        {
            cout<<sum;
        }
        else{
            cout<<-1;
        }




    }
