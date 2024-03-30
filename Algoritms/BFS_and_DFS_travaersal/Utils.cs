namespace BFS_and_DFS_travaersal
{
    public class Utils
    {
        public static void BfsTraversal(Node node)
        {
            if (node == null) return;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                Console.Write(node.Val.ToString() + " ");

                if(node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if(node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}
