using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SolutionTests
{
    private Solution _solution;

    [TestInitialize]
    public void Setup()
    {
        _solution = new Solution();
    }

    [TestMethod]
    public void IsSymmetric_NullRoot_ReturnsTrue()
    {
        Assert.IsTrue(_solution.IsSymmetric(null));
    }

    [TestMethod]
    public void IsSymmetric_SingleNode_ReturnsTrue()
    {
        var root = new TreeNode(1);
        Assert.IsTrue(_solution.IsSymmetric(root));
    }

    [TestMethod]
    public void IsSymmetric_SymmetricTree_ReturnsTrue()
    {
        var root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.left = new TreeNode(3);
        root.left.right = new TreeNode(4);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(3);
        
        Assert.IsTrue(_solution.IsSymmetric(root));
    }

    [TestMethod]
    public void IsSymmetric_AsymmetricTree_ReturnsFalse()
    {
        var root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(2);
        root.left.right = new TreeNode(3);
        root.right.right = new TreeNode(3);
        
        Assert.IsFalse(_solution.IsSymmetric(root));
    }

    [TestMethod]
    public void AddBinary_BothEmpty_ReturnsZero()
    {
        Assert.AreEqual("0", _solution.AddBinary("", ""));
    }

    [TestMethod]
    public void AddBinary_SimpleAddition_ReturnsCorrectSum()
    {
        Assert.AreEqual("11", _solution.AddBinary("1", "10"));
    }

    [TestMethod]
    public void AddBinary_WithCarry_ReturnsCorrectSum()
    {
        Assert.AreEqual("100", _solution.AddBinary("11", "1"));
    }

    [TestMethod]
    public void AddBinary_LargeNumbers_ReturnsCorrectSum()
    {
        Assert.AreEqual("10101", _solution.AddBinary("1010", "1011"));
    }
}
