#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    string str;
    string store[100];
    cin>>n;
    for (int i=0; i<n;i++)
    {
        cin>>str;
        store[i]=str;
    }

    for (int i=0; i<n;i++)
    {

       if(store[i].length()<=10)

    {
        cout<<store[i]<<endl;
    }
    else if(store[i].length()>10)
    {
        cout<<store[i].front()<<store[i].length()-2<<store[i].back()<<endl;
    }

    }









}
