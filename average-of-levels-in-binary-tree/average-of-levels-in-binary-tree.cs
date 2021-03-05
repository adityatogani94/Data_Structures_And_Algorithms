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
    public IList<double> AverageOfLevels(TreeNode root) {
        
        List<double> average = new List<double>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        
        while(queue.Count != 0)
        {
            int i = queue.Count;
            int j = queue.Count;
            double currAvg = 0;
            
            while(i>0)
            {
                TreeNode currNode = queue.Dequeue();
                currAvg += currNode.val;
                if(currNode.left != null)
                {
                    queue.Enqueue(currNode.left);
                }
                
                if(currNode.right != null)
                {
                    queue.Enqueue(currNode.right);
                }
                
                i--;
            }
            average.Add(currAvg/j);
        }
        
        return average;
    }
}