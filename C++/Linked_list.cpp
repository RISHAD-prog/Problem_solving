#include<iostream>
using namespace std;
struct Node{
    int data;
    Node* next;
};
void createnode(Node** address,int new_data)
{
    Node* n_node=new Node();
    n_node->data=new_data;
    n_node->next=NULL;
    Node* p=*address;
    if(*address==NULL)
    {
        *address=n_node;
        p=n_node;


    }
    else{
        p->next=n_node;
        p=p->next;
    }
}

void addNode(Node** h_p,int new_data)
{
    Node* n_node=new Node();
    n_node->data=new_data;
    n_node->next=(*h_p);
    (*h_p)=n_node;
}
void deleteList(Node** address, int value)
{
    Node* temp=*address;
    Node* prev=NULL;
    if(temp!=NULL && temp->data==value)
    {
        *address=temp->next;
        delete temp;
        return;
    }
    else{
        while(temp!=NULL && temp->data!=value)
        {
            prev=temp;
            temp=temp->next;
        }
         if (temp == NULL)
        return;

    prev->next = temp->next;


    delete temp;
    }
}
void printList(Node* node)
{
    while (node != NULL)
    {
        cout<<" "<<node->data;
        node = node->next;
    }
}
int main()
{
    Node* head=NULL;

    createnode(&head,10);
    addNode(&head,1);
    addNode(&head,5);
    deleteList(&head,5);



    printList(head);

}
