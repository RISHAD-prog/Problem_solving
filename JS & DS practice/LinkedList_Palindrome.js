class LinkedList_Palindrome {
    constructor(head = null) {
        this.head = head;
    }

    appendNode(newNode) {
        let node = this.head;
        if (node === null) {
            this.head = newNode;
            return;
        }
        while (node.next) {
            node = node.next;
        }
        node.next = newNode;
    }

    printList() {
        let node = this.head;
        while (node) {
            console.log(node.data);
            node = node.next;
        }
    }

    printLast(){
        let node = this.head;
        let f1 ;
        let f2 ;
        while (node) {
            if(node === this.head){
                f1 = node.data;
            }
            if(node.next === null){
                f2= node.data;
            }
            if(f1 === f2){
                console.log("palindrome");
            }
            node = node.next;
        }
        
    }
    
}

class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

let myList = new LinkedList_Palindrome();
let node = new Node(1);

myList.appendNode(node);
myList.appendNode(new Node(2));
myList.appendNode(new Node(2));
myList.appendNode(new Node(1));
myList.printList();
myList.printLast();
