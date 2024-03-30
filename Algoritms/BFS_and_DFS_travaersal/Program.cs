using BFS_and_DFS_travaersal;


static Node Build()
{
    var tree = new Node("A", 
        new Node("B", 
            new Node("C"), new Node("D")), 
        new Node("E",
            new Node("F"), new Node("G",
                                        new Node("H"), null)));
    return tree;
}

var tree = Build();

Utils.BfsTraversal(tree);
