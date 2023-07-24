#include<bits/stdc++.h>
using namespace std;
int main()
        {
            cout<<"Enter the value of n:";
            int n;
            cin>>n;
            int i;
            int j = n;

            for (int i = 0; i <n; i++)
            {
                if(j==1)
                {
                    return i;
                }
                else if (j % 2 != 0)
                {
                    j = 3 * j + 1;
                }
                else
                {
                    j = j / 2;
                }
                cout<<j<<" ";

            }

        }
