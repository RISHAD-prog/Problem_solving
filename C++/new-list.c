#include<stdio.h>
#include<stdlib.h>


struct node{
    int data;
    struct node *link;
};
void printData(struct node *head){
    if(head==NULL)
        printf("the node is empty");
    struct node *ptr=NULL;
    ptr=head;
    while(ptr != NULL){
        printf("%d ",ptr->data);
        ptr=ptr->link;
    }
}
int main (){
    struct node *head=malloc(sizeof(struct node));
    head->data=40;
    head->link=NULL;

    struct node *current=malloc(sizeof(struct node));
    current->data=30;
    current->link=NULL;
    head->link=current;

    current=malloc(sizeof(struct node));
    current->data=20;
    current->link=NULL;
    head->link->link=current;

    printData(head);
    return 0;
}


