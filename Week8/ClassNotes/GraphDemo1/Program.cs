namespace GraphDemo1
{
    // Undirected weighted graph
    internal class Program
    {
        static void Main(string[] args)
        {
            // limitations: fixed size and if vertices need to be added or removed,
            // the entire matrix needs to be recreated, which can be inefficient for large graphs.
            // Directed unweighted
            AdjacencyMatrixGraph graph = new AdjacencyMatrixGraph(5);
            graph.AddEdge(0, 1,200);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(4, 3);
            graph.Display();
            Console.ReadLine();
        }
    }
}
