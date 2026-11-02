namespace GraphDemo2
{

    class Node
    {
        public int data;
        public List<Node> neighbors;
        public Node(int data)
        {
            this.data = data;
            neighbors = new List<Node>();
        }
    }
    class Graph
    {


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UnWeighted Directed Graph: ");
            //AdjacencyListGraph graph = new AdjacencyListGraph();
            //graph.AddEdge(1, 2);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(2, 4);
            //graph.AddEdge(3, 4);
            //graph.AddEdge(4, 5);
            //graph.Display();


            WeightedDirectedGraph wGraph = new WeightedDirectedGraph();
            wGraph.AddEdge(1, 2, 5);
            wGraph.AddEdge(1, 3, 10);
            wGraph.AddEdge(2, 4, 2);
            wGraph.AddEdge(3, 4, 1);
            wGraph.AddEdge(4, 5, 3);
            wGraph.Display();
            Console.ReadLine();

        }
    }
}
