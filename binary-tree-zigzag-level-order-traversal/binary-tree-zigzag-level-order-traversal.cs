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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();

        if (root == null)
        {
            return result;
        }

        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();

        s1.Push(root);

        while (s1.Count != 0 || s2.Count != 0)
        {
            int n1 = s1.Count;
            int n2 = s2.Count;

            List<int> list = new List<int>();

            for (int i = 0; i < n1; i++)
            {
                root = s1.Pop();
                list.Add(root.val);

                if (root.left != null)
                {
                    s2.Push(root.left);
                }

                if (root.right != null)
                {
                    s2.Push(root.right);
                }
            }

            for (int i = 0; i < n2; i++)
            {
                root = s2.Pop();
                list.Add(root.val);

                if (root.right != null)
                {
                    s1.Push(root.right);
                }

                if (root.left != null)
                {
                    s1.Push(root.left);
                }
            }

            result.Add(list);
        }

        return result;
    }
}