#include<bits/stdc++.h>
using namespace std;

string encode(string p, int j)
{
   for(int i=0;i<p.length();i++)
   {
       if(i==j){

           p[i]=p[i]+2;
           j=i+j+1;
       }
   }
   return p;
}


int main()
{
    string s;
    int n;
    getline(cin,s);

    cin>>n;
    string z=encode(s,n);
    cout <<"result array:\n"<<z;
    cin.get();


}
