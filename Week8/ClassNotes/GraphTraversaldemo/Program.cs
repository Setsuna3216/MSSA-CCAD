namespace GraphTraversaldemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGraph myGraph = new MyGraph(6);
            myGraph.AddEdge(0, 1);
            myGraph.AddEdge(0, 5);
            myGraph.AddEdge(0, 4);
            myGraph.AddEdge(1, 2);
            myGraph.AddEdge(1, 3);
            myGraph.AddEdge(1, 4);
            myGraph.AddEdge(3, 4);
            myGraph.AddEdge(2, 5);
            myGraph.PrintGraph();
            Console.WriteLine("BFS Traversal is : ");
            myGraph.BFS(0);
            myGraph.ResetVisited();
            Console.WriteLine("DFS Traversal is : ");
            myGraph.DFS(0);
            Console.ReadLine();

        }
    }
}
