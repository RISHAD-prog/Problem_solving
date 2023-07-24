

#include<bits/stdc++.h>
using namespace std;
int main()
{
    string name;
    int dup=0;
    int m;
    cin>>name;
    int n=name.length();
    for (int i=0; i<n; i++)
     {
         int j;
        for ( j=0; j<i; j++)
        {
         if(name[i]==name[j])
         {
             break;

         }


        }
        if(j==i)
         {
             name[dup++]=name[i];
         }

     }
if(dup%2!=0 )
     {
         cout<<"IGNORE HIM!";
     }
     if(dup%2==0 ){
        cout<<"CHAT WITH HER!";
     }
}

