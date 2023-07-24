#include<bits/stdc++.h>
using namespace std;
int main()
{
    char str1[20]="ABCD";
    char str2[20] ="abcd";
    char str3[20]="ABCD";

    int result;

    result=strcmp(str1,str2);
    cout<<"for (s1,s2)->"<<result<<endl;

    result=strcmp(str1,str3);
    cout<<"for (s1,s3)->"<<result;

     return 0;
}
