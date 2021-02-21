/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    List<TreeNode> listofnodes = new List<TreeNode>();
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) 
    {
        if(root == null)
        {
            return null;
        }
        
        traversal(root);
        
        for(int i=0; i<listofnodes.Count ; i++)
        {
            if(listofnodes[i]!=null)
            {
               if(listofnodes[i].val == p.val)
                {
                    if(i != listofnodes.Count-1)
                        return listofnodes[i+1];
                    else
                        return null;
                } 
            }
        }
        return null;
    }
    public void traversal(TreeNode node)
    {
        if(node == null)
        {
            return;
        }
        traversal(node.left);
        listofnodes.Add(node);
        traversal(node.right);
    }
}