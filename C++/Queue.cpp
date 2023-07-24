#include<bits/stdc++.h>
using namespace std;
int front=-1;
int rear=-1;
int MaxSize=100;
int Queue[100];

bool isFull()
{
    if(rear==MaxSize)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool isEmpty()
{
    if(front==-1 && rear==-1)
    {
        return true;
    }
    else{
        return false;
    }
}
bool enqueue(int element)
{
    if(isFull())
    {
        cout<<"Queue is full";
        return false;
    }
    else if(isEmpty())
    {
        front=rear=0;
        Queue[rear]=element;
        return true;
    }
    else
    {
    rear++;
    Queue[rear]=element;
    return true;
    }
}
bool dequeue()
{
    if(isEmpty())
    {
        cout<<"Queue is empty";
        return false;
            }
            else{
                front++;
                return true;
            }
}
void show()
{
    if(isEmpty())
    {
        cout<<"Queue is empty";
    }
    else{
        for(int i=front;i<=rear;i++)
        {
            cout<<Queue[i]<<endl;
        }
    }

}
int main()
{
    enqueue(10);
    enqueue(1);
    enqueue(5);
    show();
    dequeue();
    show();
}
