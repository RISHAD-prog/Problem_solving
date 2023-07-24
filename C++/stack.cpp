#include<bits/stdc++.h>
using namespace std;


    int Top=0;
    int Stack[100];
    int MaxSize=100;

bool isEmpty()
{
    if(Top==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool isFull()
{
    if(Top==MaxSize)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool push(int element)
{
    if(isFull())
    {
       cout<<"stack is full";
       return false;
    }
    Stack[Top++]=element;
    return true;
}
bool pop()
{
    if(isEmpty())
    {
       cout<<"stack is empty";
       return false;
    }
    Top--;
    return true;
}
int Topelement()
{

    return Stack[Top-1];



}
void show()
{
    if(isEmpty())
        { cout << "Stack empty\n"; return; }
	for( int i=Top-1; i>=0; i-- )
	cout << Stack[i] << endl;
}
int main()
{
    int n;
    push(5);
    push(1);
    push(10);
    cout<<"Top element:"<<Topelement()<<endl;
    cout<<"Stack:"<<endl;
    show();

    pop();
    cout<<"After pop top element:"<<Topelement()<<endl;
    cout<<"After pop"<<endl;
    show();
}
