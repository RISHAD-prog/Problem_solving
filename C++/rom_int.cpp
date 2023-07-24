#include<bits/stdc++.h>
using namespace std;
class Solution {
public:
    int romanToInt(string s) {
	   int integer[7]={1,5,10,50,100,500,1000};
	   int sum=0;
	   char arr[s.length()+1];
        strcpy(arr, s.c_str());
	   for (int i=0;i<s.length();i++)
	   {
		if(arr[i]=='I')
		{
			if(arr[i+1]=='V')
			{
				sum=sum+integer[1]-integer[0];
				i++;
			}
			else if(arr[i+1]=='X')
			{
				sum=sum+integer[2]-integer[0];
				i++;
			}
			else
			{
				sum=sum+integer[0];
			}
		}
		else if(arr[i]=='V')
		{
			sum=sum+integer[1];
		}
		else if(arr[i]=='X')
		{
			if(arr[i+1]=='L')
			{
				sum=sum+integer[3]-integer[2];
				i++;
			}
			else if(arr[i+1]=='C')
			{
				sum=sum+integer[4]-integer[2];
				i++;
			}
			else
			{
				sum=sum+integer[2];
			}
		}
		else if(arr[i]=='L')
		{
			sum=sum+integer[3];
		}
		else if(arr[i]=='C')
		{
			if(arr[i+1]=='D')
			{
				sum=sum+integer[5]-integer[4];
				i++;
			}
			else if(arr[i+1]=='M')
			{
				sum=sum+integer[6]-integer[4];
				i++;
			}
			else
			{
				sum=sum+integer[4];
			}

		}
		else if(arr[i]=='D')
		{
			sum=sum+integer[5];
		}
		else if(arr[i]=='M')
		{
			sum=sum+integer[6];
		}
		else
		{
			sum=0;
		}

	   }
		   return sum;
    }

};

    int main(){
        Solution sol;
    string s;
    cout<<"s=";
    cin>>s;
    int result=sol.romanToInt(s);
    cout<<result;
    return 0;
    }


