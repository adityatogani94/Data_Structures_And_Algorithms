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
    public int GoodNodes(TreeNode root) {
        if (root == null) { return 0; }
        
        int goodNodeCount = 0;
        Traverse(root, root.val, ref goodNodeCount);
        return goodNodeCount;
    }
    
    private void Traverse(TreeNode node, int maxPathValue, ref int goodNodeCount)
    {
        if (node == null) { return; }
        
        if (maxPathValue <= node.val) { maxPathValue = node.val;  goodNodeCount++; }
        
        Traverse(node.left, maxPathValue, ref goodNodeCount);
        Traverse(node.right, maxPathValue, ref goodNodeCount);
    }
}