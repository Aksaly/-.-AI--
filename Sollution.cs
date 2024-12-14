public class Solution {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsMirror(root.left, root.right);
    }
    
    private bool IsMirror(TreeNode left, TreeNode right) {
        if (left == null && right == null) return true;
        if (left == null || right == null) return false;
        return (left.val == right.val) &&
               IsMirror(left.right, right.left) &&
               IsMirror(left.left, right.right);
    }
    
    public string AddBinary(string a, string b) {
        int sum = Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2);
        return Convert.ToString(sum, 2);
    }
}
