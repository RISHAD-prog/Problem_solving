#include<iostream>
#define length 10
using namespace std;
int AscendingBinarySearch(int Arr[],int key,int low,int high){
int mid=0;
while (mid<length)
{
mid=low+(high-low)/2;
if (Arr[mid]==key)
{
return mid

}
else if (Arr[mid]>key)
{
high=mid-1;
}else if (Arr[mid]<key)
{
low=mid+1;
}
}
return -1;
}
void input(int arr[]){
for (int i = 0; i < length; i++)
{
cin>>arr[
}
}
void output(int arr[]){
cout<<"Numbers:";
for (int i = 0; i < length; i++)
{
cout<<arr[i]<<" ";
}
cout<<endl;
}
int main()
{
int n[length];
int find;
cout<<"Enter "<<length<<" Numbers as Ascending Order:";
input(n);
output(n);
cout<<"Enter the value you want to find: ";
cin>>find;
int index=AscendingBinarySearch(n,find,0,length-1);
if (index!=-1)
{
cout<<"Value Found at index: "<<index<<endl;
}else{
cout<<"Value Not found!"<<endl;
