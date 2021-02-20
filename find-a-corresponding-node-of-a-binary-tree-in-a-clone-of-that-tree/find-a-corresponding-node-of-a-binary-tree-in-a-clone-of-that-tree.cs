public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if (original == target) return cloned;
        TreeNode answer = null;
        if (original.right != null)
            answer = GetTargetCopy(original.right, cloned.right, target);
        if (answer == null && original.left != null) 
            answer = GetTargetCopy(original.left, cloned.left, target);
        return answer;
    }
}