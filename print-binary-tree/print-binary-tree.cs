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
    private IList<IList<string>> res = new List<IList<string>>();
    
    public IList<IList<string>> PrintTree(TreeNode root) {
        if (root == null)
            return res;
        
        int h = GetHeight(root);
        
        for (int i = 0; i < h; i++)
            res.Add(Enumerable.Repeat(string.Empty, (int)(Math.Pow(2, h - 1)) * 2 - 1).ToList());
        
        DFS(root, 0, 0, res[0].Count - 1);
        
        return res;
    }
    
    private int GetHeight(TreeNode node)
    {
        if (node == null)
            return 0;
        
        return Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
    }
    
    private void DFS(TreeNode node, int i, int j, int k)
    {
        int mid = j + (k - j) / 2;
        
        res[i][mid] = node.val.ToString();
            
        if (node.left != null)
            DFS(node.left, i + 1, j, mid - 1);
        
        if (node.right != null)
            DFS(node.right, i + 1, mid + 1, k);
    }
}