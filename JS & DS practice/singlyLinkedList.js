class SinglyLinkedList {
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
    
}

class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

let myList = new SinglyLinkedList();
let node = new Node(1);

myList.appendNode(node);
myList.appendNode(new Node(2));
myList.appendNode(new Node(2));
myList.appendNode(new Node(1));
myList.printList();
