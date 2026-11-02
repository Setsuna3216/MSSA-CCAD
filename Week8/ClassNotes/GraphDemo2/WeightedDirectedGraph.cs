using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDemo2
{
    internal class WeightedDirectedGraph
    {
        // key=vertex number
        //value=neighbour list with weights
        //private Dictionary<string, List<string>> names;optional

        private Dictionary<int, List<(int neighbor, int weight)>> adjList;
        public WeightedDirectedGraph()
        {
            adjList = new Dictionary<int, List<(int neighbor, int weight)>>();
        }
        public void AddVertex(int vertex)
        {
            if (!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<(int neighbor, int weight)>();// holds the adjacent vertices and weights
            }
        }
        public void AddEdge(int fromVertex, int toVertex, int weight)
        {
            // to make sure that these vertices are already added as keys
            if (!adjList.ContainsKey(fromVertex))
            {
                AddVertex(fromVertex);
            }
            if (!adjList.ContainsKey(toVertex))
            {
                AddVertex(toVertex);
            }
            adjList[fromVertex].Add((toVertex, weight));
        }

        public void Display()
        {
            foreach (var vertex in adjList)
            {
                Console.Write(vertex.Key + " -> ");


                //foreach(var item in vertex.Value)
                //{
                //    Console.Write($"({item.neighbor}, weight: {item.weight}) ");
                //}
                foreach (var (neighbor, weight) in vertex.Value)
                {
                    Console.Write($"({neighbor}, weight: {weight}) ");
                }
                Console.WriteLine();
            }
        }
    }
}
