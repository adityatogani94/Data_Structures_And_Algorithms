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
    private int res = 0;
    
    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        
        return res;
    }
    
    private int DFS(TreeNode node)
    {
        if (node == null)
            return 0;
        
        int lMax = DFS(node.left),
            rMax = DFS(node.right);
        
        res = Math.Max(lMax + rMax, res);
        
        return Math.Max(lMax, rMax) + 1;
    }
}