/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        //if the root does not contain any of the nodes
        if(!covers(root, p) || !covers(root, q))
        {
            return null;
        }
        return LCAFinder(root, p, q);
    }
    
    public bool covers(TreeNode root, TreeNode p)
    {
        if(root == null) return false;
        if(root == p) return true;
        return covers(root.left, p) || covers(root.right, p);
    }
    
    public TreeNode LCAFinder(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null || root == p || root == q){
            return root;
        }
        
        bool pIsOnLeft = covers(root.left, p);
        bool qIsOnLeft = covers(root.left, q);
        
        if(pIsOnLeft != qIsOnLeft) return root;
        
        TreeNode child = pIsOnLeft ? root.left : root.right;
        return LCAFinder(child, p, q);
    }
}