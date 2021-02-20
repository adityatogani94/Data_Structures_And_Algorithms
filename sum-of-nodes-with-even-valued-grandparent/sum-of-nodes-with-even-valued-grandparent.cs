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
    private void Helper(TreeNode node, TreeNode parent, TreeNode grandParent, ref int res)
        {
            if (node == null)
            {
                return;
            }

            if (grandParent != null && grandParent.val % 2 == 0)
            {
                res += node.val;
            }

            grandParent = parent;
            parent = node;
            Helper(node.left, parent, grandParent, ref res);
            Helper(node.right, parent, grandParent, ref res);
        }


        public int SumEvenGrandparent(TreeNode root)
        {
            int res = 0;
            Helper(root, null, null, ref res);
            return res;
        }
}