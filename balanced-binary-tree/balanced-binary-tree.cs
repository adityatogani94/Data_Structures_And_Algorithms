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
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root == null)
        {
            return true;
        }
        int heightDiff = getHeight(root.left) - getHeight(root.right);
        if(Math.Abs(heightDiff)>1){
            return false;
        }
        else
        {
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
    }
    
    public int getHeight(TreeNode node)
    {
        if(node == null)
        {
            return -1;
        }
        return Math.Max(getHeight(node.left), getHeight(node.right)) +1;
    }
}