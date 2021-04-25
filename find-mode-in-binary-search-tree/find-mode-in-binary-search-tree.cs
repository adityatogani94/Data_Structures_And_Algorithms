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
    List<int> inOrderTraversal;    
    public int[] FindMode(TreeNode root) {
        
        if(root.left == null && root.right == null)
        {
            return new int[]{root.val};    
        }
        
        inOrderTraversal = new List<int>();
        inOrder(root);
        List<int> ans = new List<int>();
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        int currentMax = 0;
        foreach(int val in inOrderTraversal)
        {
            if(map.ContainsKey(val))
            {
                map[val]++;
                currentMax = Math.Max(currentMax, map[val]);
            }
            else
            {
                map.Add(val,1);
                currentMax = Math.Max(currentMax, map[val]);
            }
        }
        
        foreach(int val in map.Keys)
        {
            if(map[val] == currentMax)
            {
                ans.Add(val);
            }
        }
        
        
        return ans.ToArray();
    }
    
    public void inOrder(TreeNode root){
        if (root == null){
            return;
        }
        inOrder(root.left);
        inOrderTraversal.Add(root.val);
        inOrder(root.right);   
    }
}