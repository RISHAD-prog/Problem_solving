#include<bits/stdc++.h>
using namespace std;

struct node{
    int data;
    struct node *link;
};
void printData(struct node *head){
    if(head==NULL){
        cout<<"the node is empty";
    }
    struct node *ptr=NULL;
    ptr=head;
    while(ptr!=NULL){
        cout<<ptr->data;
        ptr=ptr->link;
    }
}
int main (){
    struct node *head=malloc(sizeof(struct node));
    head->data=40;
    head->link=NULL;

    struct node *current=malloc(sizeof(struct node));
    head->data=30;
    current->link=NULL;
    head->link=current;

    current=malloc(sizeof(struct node));
    head->data=20;
    current->link=NULL;
    head->link->link=current;

    printData(head);
    return 0;
}

