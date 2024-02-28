public class Solution
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val )
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }
    TreeNode root;
    Queue<int> queue = new Queue<int>();
    Solution() { root = null; }
    void AddNode(int key) { root = AddNode(root, key); }

    TreeNode AddNode(TreeNode root, int key)
    {
        if(root == null)
        {
            root = new TreeNode(key);
            return root;
        }
        if(root.val < key)
        {
            root.right = AddNode(root.right, key);   
        }
        else if(root.val > key)
        {
            root.left = AddNode(root.left, key);
        }
        return root;
    }
    public int FindBottomLeftValue(TreeNode root)
    {
       
        if (root != null)
        {
            
            FindBottomLeftValue(root.left);
            FindBottomLeftValue(root.right);
            queue.Enqueue(root.val);
        }
        return queue.Count != 0 ? queue.Peek() : 0;
    }
    public static void Main(string[] args)
    {
        Solution s = new Solution();
        s.AddNode(1);
        s.AddNode(2);
        s.AddNode(3);
        s.AddNode(4);
        s.AddNode(5);
        s.AddNode(6);
        s.AddNode(7);
        var ans = s.FindBottomLeftValue(s.root);
        Console.WriteLine(ans);
    }
}