
namespace TreeMaxSumFromRootToLeaf
{
    public class TreeNode
    {
        public int Val { get; set; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(int data, TreeNode left, TreeNode right)
        {
            Left = left;
            Right = right;
            Val = data;
        }
        public TreeNode(int data)
        {
            Val = data;
            Left = null;
            Right = null;
        }
    }
}
