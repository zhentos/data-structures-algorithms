namespace BFS_and_DFS_travaersal
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public string Val { get; set; }
        public Node(string data, Node left, Node right) 
        {
            Left = left;
            Right = right;
            Val = data;
        }
        public Node(string data) 
        {
            Val = data;
            Left = null;
            Right = null;
        }
    }
}
