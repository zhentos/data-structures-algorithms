 public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;

      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
        this.val = val;
        this.left = left;
        this.right = right;
      }
  }

internal class Program
{
    public static int SumOfLeftLeaves(TreeNode root)
    {
        return SumLeftLeaves(root, false);
    }
    private static void Main(string[] args)
    {
        var root = new TreeNode(1);
        SumLeftLeaves(root, false);
    }

    private static int SumLeftLeaves(TreeNode node, bool isLeft)
    {
        if (node == null) return 0;

        // Если узел - лист и он левый, возвращаем его значение
        if (node.left == null && node.right == null && isLeft)
            return node.val;

        // Рекурсивно обходим левое и правое поддеревья
        return SumLeftLeaves(node.left, true) + SumLeftLeaves(node.right, false);
    }
}