using System.Xml.Linq;

public class Program
{
    public ListNode head;
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val= 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
    public void InsertNode(int val)
    {
        ListNode new_node = new ListNode(val);
        new_node.next=head;
        head = new_node;
    }
    public ListNode MiddleNode(ListNode head)
    {
        ListNode slow_ptr = head;
        ListNode fast_ptr = head;
        while (fast_ptr != null &&
               fast_ptr.next != null)
        {
            fast_ptr = fast_ptr.next.next;
            slow_ptr = slow_ptr.next;
        }
        head = slow_ptr;
        return head;
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.InsertNode(5);
        program.InsertNode(4);
        program.InsertNode(3);
        program.InsertNode(2);
        program.InsertNode(1);

        program.MiddleNode(program.head);
       
    }
}
