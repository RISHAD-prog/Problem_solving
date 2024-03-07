public class Program
{
    public ListNode head;
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    //public void InsertNode(int val)
    //{
    //    ListNode new_node = new ListNode(val);
    //    new_node.next = head;
    //    head = new_node;
    //}
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return false;
        }
        ListNode slow_ptr = head;
        ListNode fast_ptr = head.next;
        while (slow_ptr!=fast_ptr)
        {
            if(fast_ptr == null || fast_ptr.next==null)
            {
                return false;
            }
            fast_ptr = fast_ptr.next.next;
            slow_ptr = slow_ptr.next;
        }
        
        return true;
    }
    private ListNode CreateLinkedListWithCycle(int[] values, int pos)
    {
        if (values == null || values.Length == 0)
        {
            return null;
        }

        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        ListNode cycleNode = null;

        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;

            if (i == pos)
            {
                cycleNode = current;
            }
        }
        current.next = cycleNode;

        return head;
    }

    public static void Main(string[] args)
    {
        Program program = new Program();


        int[] inputValues = { 3, 2, 0, -4 };
        int cyclePos = 1;

        ListNode head = program.CreateLinkedListWithCycle(inputValues, cyclePos);

        bool hasCycle = program.HasCycle(head);

        Console.WriteLine("Output: " + hasCycle); 
    }
    //public static void Main(string[] args)
    //{
    //    Program program = new Program();
    //    program.InsertNode(-4);
    //    program.InsertNode(0);
    //    program.InsertNode(2);
    //    program.InsertNode(3);

    //    var ans = program.HasCycle(program.head);
    //    Console.WriteLine(ans);
    //}
}