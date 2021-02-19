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
    List<TreeNode> lt = new List<TreeNode>();
    public TreeNode ConvertBST(TreeNode root) {
        if(root == null)
        {
            return root;
        }
        if(root.left == null && root.right == null)
        {
            return root;
        }
        InOrderTraversal(root);
        int sum = SumOfNodes();
        Console.WriteLine(sum);
        int currSum = 0;
        int temp = 0;
        foreach(TreeNode node in lt)
        {
            temp = node.val;
            node.val = sum-currSum;
            currSum += temp;
        }
        return root;
    }
    
    public int SumOfNodes()
    {
        int sum = 0;
        foreach(TreeNode node in lt)
        {
            sum += node.val;
        }
        return sum;
    }
    
    public void InOrderTraversal(TreeNode root)
    {
        if(root==null)
        {
            return;
        }
        InOrderTraversal(root.left);
        lt.Add(root);
        InOrderTraversal(root.right);
    }
}