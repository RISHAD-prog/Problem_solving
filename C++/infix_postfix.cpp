#include<bits/stdc++.h>
#define SIZE 100
using namespace std;
int Top=0;
int Stack[100];
int MaxSize=100;
int Queue[100];
int front=-1;
int rear=-1;
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
bool push(char element)
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
bool isFullQueue()
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
bool isEmptyQueue()
{
    if(front==-1 && rear==-1)
    {
        return true;
    }
    else{
        return false;
    }
}
bool enqueue(char element)
{
    if(isFullQueue())
    {
        cout<<"Queue is full";
        return false;
    }
    else if(isEmptyQueue())
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
    if(isEmptyQueue())
    {
        cout<<"Queue is empty";
        return false;
            }
            else{
                front++;
                return true;
            }
}
int precedence(char op)
{
    if(op=='+'||op=='-')
    {
        return 1;
    }
    else if(op=='*'||op=='/')
    {
        return 2;
    }
    else{
        return 0;
    }
}
bool infix_postfix(char infix[],int Size)
{

    push('(');
    infix[Size];
    int j=0;
    while (infix[j]!='\0')
    {

        if(infix[j]!='+'||infix[j]!='-'||infix[j]!='*'||infix[j]!='/'||infix[j]!='('||infix[j]!=')')
        {
            enqueue(infix[j]);
            j++;
            return true;
        }
        else{
            if(infix[j]=='(')
            {
                push(infix[j]);
                j++;
                return true;
            }
            else if(infix[j]==')')
            {
                while(Topelement()!='(')
                {
                    enqueue(Topelement());
                    pop();
                }
                pop();
                j++;
                return true;
            }
            else{
                while(precedence(infix[j])<=precedence(Topelement()))
                {
                    enqueue(Topelement());
                    pop();

                }
                push(infix[j]);
                j++;
                return true;
            }
        }
    }

}
void show()
{
    if(isEmptyQueue())
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
    char infix[SIZE]={'2','*','4','+','(','6','-','3',')','/','3'};
	cout<<"ASSUMPTION: The infix expression contains single letter variables and single digit constants only.\n";



	infix_postfix(infix,SIZE);
    show();

	return 0;


}
