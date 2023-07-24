#include<iostream>
#define size 6
using namespace std;
int AscendingBinarySearch(int Arr[],int key,int low,int high){
    while (high>=low)
    {
        int mid=(high+low)/2;
        if (Arr[mid]==key && key>=18)
        {
            return Arr[mid];
        }else if (Arr[mid]<key)
        {
            low=mid+1;
        }else{
            high=mid-1;
        }
    }
    return -1;

}
void input(int arr[]){
    for (int i = 0; i < size; i++)
    {
        cin>>arr[i];
    }
}
void output(int arr[]){
    cout<<"Numbers:";
    for (int i = 0; i < size; i++)
    {
        cout<<arr[i]<<" ";
    }
    cout<<endl;
}
int main(){

    int n[size];
    int find;
    cout<<"Give "<<size<<" ages in ascending Order:";
    input(n);
    output(n);
    cout<<"Enter the value you want to find: ";
    cin>>find;
    int index=AscendingBinarySearch(n,find,0,size-1);
    if (index!=-1)
    {
            cout<<index;



    }else
    {
        cout<<"Value Not found!"<<endl;
    }

return 0;

}

