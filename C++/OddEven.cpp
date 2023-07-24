#include<bits/stdc++.h>
using namespace std;
int main()
{
    int number[10];
    int odd=0;
     int even=0;
    cout<<" Enter the elements: " ;
    for (int i=0; i<10; i++)
    {
        cin>>number[i];

    }
    for (int i=0; i<10; i++)
    {
        if(number[i]%2==0)
        {

           odd++;

        }
        else{
            even++;
        }


    }
    cout<<odd<<" Odd numbers" <<endl;
    cout<<even<<" Even Numbers"<<endl;

}
