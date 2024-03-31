namespace TreeMaxSumFromRootToLeaf
{
    public static class Utils
    {
        public static TreeNode Build()
        {
            var tree = new TreeNode(1,
                new TreeNode(4,
                    new TreeNode(2), new TreeNode(3,
                                            new TreeNode(2), null)),
                new TreeNode(7,
                    new TreeNode(5), new TreeNode(4)));
            return tree;
        }
    }
 }
