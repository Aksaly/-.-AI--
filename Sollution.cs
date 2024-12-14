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
public string AddBinaryAlternative(string a, string b) {
        StringBuilder result = new StringBuilder();
        int carry = 0;
        int i = a.Length - 1;
        int j = b.Length - 1;
        
        while (i >= 0 || j >= 0 || carry > 0) {
            int sum = carry;
            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';
            result.Insert(0, sum % 2);
            carry = sum / 2;
        }
        
        return result.ToString();
    }
    
    public bool IsSymmetricAlternative(TreeNode root) {
        if (root == null) return true;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        
        while (queue.Count > 0) {
            TreeNode t1 = queue.Dequeue();
            TreeNode t2 = queue.Dequeue();
            
            if (t1 == null && t2 == null) continue;
            if (t1 == null || t2 == null) return false;
            if (t1.val != t2.val) return false;
            
            queue.Enqueue(t1.left);
            queue.Enqueue(t2.right);
            queue.Enqueue(t1.right);
            queue.Enqueue(t2.left);
        }
        
        return true;
    }
