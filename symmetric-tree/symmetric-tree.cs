/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
       public bool marked;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null, bool marked=false) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
           this.marked = false;
 *     }
 * }
 */
public class Solution 
{
    public bool IsSymmetric(TreeNode root) 
    {
        if (root == null) return true;

        return IsSymmetric(root.left, root.right);
    }

    private bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;

        if (left.val == right.val)
        {
            return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
        }
        return false;
    }
}