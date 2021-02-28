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
    public TreeNode SearchBST(TreeNode root, int val) {
        if(root.val == val)
        {
            return root;
        }
        TreeNode ans = traverse(root, val);
        return ans;
    }
    
    public TreeNode traverse(TreeNode node, int val)
    {
        if(node == null)
        {
            return null;
        }
        else if(node.val == val)
        {
            return node;
        }
        else if(node.val < val)
        {
            return traverse(node.right, val);
        }
        else
        {
            return traverse(node.left, val);
        }
    }
}