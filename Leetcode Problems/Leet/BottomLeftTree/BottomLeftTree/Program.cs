public class Solution
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0 )
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }
    TreeNode root;
   
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
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode current = root;
        queue.Enqueue(current);
        while(queue.Count > 0)
        {
            current = queue.Dequeue();
            if(current.right != null)
            {
                queue.Enqueue(current.right);   
            }
            if(current.left != null)
            {
                queue.Enqueue(current.left);
            }
        }
        return current.val;
    }
    

    public static void Main(string[] args)
    {
        Solution s = new Solution();
        s.AddNode(0);
        s.AddNode(-1);

        var ans = s.FindBottomLeftValue(s.root);
        Console.WriteLine(ans);
    }
}