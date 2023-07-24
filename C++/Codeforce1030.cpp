
#include<bits/stdc++.h>
using namespace std;
int main()
{
    int n;
    int c[100];

    cin>>n;
    for(int i=0; i<n; i++)
    {
        cin>>c[i];
    }
        int easy=1;
    for(int i=0; i<n; i++)
    {
        if(c[i]==1)
        {
            easy=0;

        }
    }

    if(easy==0)
    {
        cout<<"HARD";
    }
    else{
        cout<<"EASY";
    }

}
