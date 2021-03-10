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
    public IList<int> PostorderTraversal(TreeNode root)
    {
      List<int> res = new List<int>();

      Helper(root, res);

      return res;
    }

    public void Helper(TreeNode node, List<int> res)
    {
      if (node == null) return;

      Helper(node.left, res);
      Helper(node.right, res);

      res.Add(node.val);
    }        
}