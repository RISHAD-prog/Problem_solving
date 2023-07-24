#include<bits/stdc++.h>
using namespace std;

int main()
{
    int test_case,row,col;
    int c=0;
    int m=0;
    cin>>test_case;

    for (int i=0;i<test_case;i++)
    {
        cin>>row;
        cin>>col;
        char arr[row][col];
        for(int j=0;j<row;j++)
        {
            for(int k=0;k<col;k++)
            {
                cin>>arr[j][k];
                if (arr[j][k]=='#')
                {
                    c++;
                }
            }
            if(m<c)
            {
                m=c;
            }

            c=0;
        }
        cout<<m<<endl;
        m=0;
    }


}
