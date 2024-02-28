using static Solution;

public class Solution
{
    ListNode head = null;
    public class ListNode
    {
        public int val;
        public ListNode next;
  
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
        }
    }
    ListNode sortedMerge(ListNode a, ListNode b)
    {
        ListNode result = null;
        /* Base cases */
        if (a == null)
            return b;
        if (b == null)
            return a;

        /* Pick either a or b, and recur */
        if (a.val <= b.val)
        {
            result = a;
            result.next = sortedMerge(a.next, b);
        }
        else
        {
            result = b;
            result.next = sortedMerge(a, b.next);
        }
        return result;
    }
    ListNode mergeSort(ListNode h)
    {
        // Base case : if head is null
        if (h == null || h.next == null)
        {
            return h;
        }

        // get the middle of the list
        ListNode middle = getMiddle(h);
        ListNode nextofmiddle = middle.next;

        // set the next of middle ListNode to null
        middle.next = null;

        // Apply mergeSort on left list
        ListNode left = mergeSort(h);

        // Apply mergeSort on right list
        ListNode right = mergeSort(nextofmiddle);

        // Merge the left and right lists
        ListNode sortedlist = sortedMerge(left, right);
        return sortedlist;
    }

    // Utility function to get the
    // middle of the linked list
    ListNode getMiddle(ListNode h)
    {
        // Base case
        if (h == null)
            return h;
        ListNode fastptr = h.next;
        ListNode slowptr = h;

        // Move fastptr by two and slow ptr by one
        // Finally slowptr will point to middle ListNode
        while (fastptr != null)
        {
            fastptr = fastptr.next;
            if (fastptr != null)
            {
                slowptr = slowptr.next;
                fastptr = fastptr.next;
            }
        }
        return slowptr;
    }


    public void push(int x)
    {
        ListNode new_ListNode =  new ListNode(x);

        new_ListNode.next = head;
        head = new_ListNode;
    }
    void printList(ListNode headref)
    {
        while (headref != null)
        {
            Console.Write(headref.val + " ");
            headref = headref.next;
        }
    }
    public static void Main(string[] args)
    {
        Solution li = new Solution();

        li.push(4);
        li.push(2);
        li.push(1);
        li.push(3);
        li.head = li.mergeSort(li.head);
        Console.Write("\n Sorted Linked List is: \n");
        li.printList(li.head);
    }
}