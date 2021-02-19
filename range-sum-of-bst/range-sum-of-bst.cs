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
    public int RangeSumBST(TreeNode root, int L, int R) {
        if (root == null) return 0;
        var sum = 0;
        if (L <= root.val && root.val <= R) {
            sum = root.val;
        }
        var left = RangeSumBST(root.left, L, R);
        var right = RangeSumBST(root.right, L, R);
        return sum + left + right;
    }
}