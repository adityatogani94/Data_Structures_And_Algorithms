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
public class Solution
{
    public int DeepestLeavesSum(TreeNode root) 
    {
        var levelSum = new List<int>();
        Traverse(root, 0, levelSum);
        return levelSum.Count == 0 ? 0 : levelSum[levelSum.Count - 1];
    }
    
    private void Traverse(TreeNode root, int level, List<int> levelSum)
    {
        if(root == null) return;
        if(level == levelSum.Count)
            levelSum.Add(0);
        levelSum[level] += root.val;
        Traverse(root.left, level + 1, levelSum);
        Traverse(root.right, level + 1, levelSum);
    }
}