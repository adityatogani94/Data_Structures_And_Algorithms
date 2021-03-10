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
public class BSTIterator
{

    List<TreeNode> InOrder;
    int itr;
    
    public BSTIterator(TreeNode root) 
    {
        itr = 0;
        InOrder = InorderTraversal(root);
    }
    
    /** @return the next smallest number */
    public int Next()
    {
        int result = InOrder[itr].val;
        itr++;
        return result;
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() 
    {
        return itr < InOrder.Count;
    }
    
    private List<TreeNode> InorderTraversal(TreeNode root)
    {
        if (root == null) return new List<TreeNode>(); 

        List<TreeNode> left = InorderTraversal(root.left);
        left.Add(root);
        List<TreeNode> right = InorderTraversal(root.right);

        if (right.Count > 0)
        {
            foreach (TreeNode treeNode in right)
            {
                left.Add(treeNode);
            }
        }

        return left; 
    }
}
/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */