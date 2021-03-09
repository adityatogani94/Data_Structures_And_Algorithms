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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ans = new List<int>();
        callDFS(root, ans);    
        return ans;
    }
    
    public void callDFS(TreeNode root, List<int> ans){
        if(root == null)
        {
            return;
        }
        if(root.left!=null)
            callDFS(root.left, ans);
        ans.Add(root.val);
        if(root.right!=null)
            callDFS(root.right, ans);
    }
}