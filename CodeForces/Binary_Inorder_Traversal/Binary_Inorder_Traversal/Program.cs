
using System.Xml.Linq;
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public class TreeNode
    {
      public int key;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.key = val;
            this.left = left;
            this.right = right;
        }
    }
    TreeNode root;

    // Constructor
    Solution() { root = null; }

    Solution(int value) { root = new TreeNode(value); }

    // This method mainly calls insertRec()
    void insert(int key) { root = insertRec(root, key); }

    // A recursive function to insert
    // a new key in BST
    TreeNode insertRec(TreeNode root, int key)
    {

        // If the tree is empty,
        // return a new node
        if (root == null)
        {
            root = new TreeNode(key);
            return root;
        }

        // Otherwise, recur down the tree
        if (key < root.key)
            root.left = insertRec(root.left, key);
        else if (key > root.key)
            root.right = insertRec(root.right, key);

        // Return the (unchanged) node pointer
        return root;
    }

    // This method mainly calls InorderRec()
    void inorder() { inorderRec(root); }

    // A utility function to
    // do inorder traversal of BST
    void inorderRec(TreeNode root)
    {
        if (root != null)
        {
            inorderRec(root.left);
            Console.Write(root.key + " ");
            inorderRec(root.right);
        }
    }
    public static void Main(String[] args)
    {
        Solution tree = new Solution();


        tree.insert(1);
        tree.insert(2);
        tree.insert(3);
        tree.insert(4);

        // Print inorder traversal of the BST
        tree.inorder();
    }
    /*public IList<int> InorderTraversal(TreeNode root)
    {

    }*/
}