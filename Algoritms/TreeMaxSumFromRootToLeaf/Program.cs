using TreeMaxSumFromRootToLeaf;


internal class Program
{
    private static void Main(string[] args)
    {
        var tree = Utils.Build();

        var maxSum = MaxPathSum(tree);

        Console.WriteLine(maxSum);
    }

    static int MaxPathSum(TreeNode root)
    {
        if (root == null) return 0;

        int maxPathLeft = MaxPathSum(root.Left);
        int maxPathRight = MaxPathSum(root.Right);
        return Math.Max(maxPathLeft, maxPathRight) + root.Val;
    }
}