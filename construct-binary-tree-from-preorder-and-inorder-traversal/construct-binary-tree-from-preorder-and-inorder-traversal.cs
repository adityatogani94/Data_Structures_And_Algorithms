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
    int preIndex = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        int start = 0;
        int end = inorder.Length -1;
        return Helper(preorder, inorder, start, end);
    }
    
    public TreeNode Helper(int[] preorder, int[] inorder, int start, int end)
    {
        if (start > end) { 
            return null; 
        } 
        TreeNode tNode = new TreeNode(preorder[preIndex++]); 
        if (start == end) { 
            return tNode; 
        }
        int inIndex = FindInOrder(inorder, tNode.val, start, end);
        tNode.left = Helper(preorder, inorder, start, inIndex - 1); 
        tNode.right = Helper(preorder, inorder, inIndex + 1, end);
        return tNode;
    }
    
    public int FindInOrder(int[] inorder, int x, int start, int end)
    {
        int i;
        for(i=start; i<=end; i++)
        {
            if(inorder[i] == x)
            {
                return i;
            }
        }
        return i;
    }
}