using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDemo2
{
    //Undirected, unweighted graph using adjacency list representation
    internal class AdjacencyListGraph
    {
        // vertex1 -> [vertex2, vertex3, ...]
        //verrtex2->[vertex1
        private Dictionary<int, List<int>> adjList;
        private Dictionary<int,string> vertexLabels; // Optional: to store vertex labels if needed
        public AdjacencyListGraph()
        {
            
            adjList = new Dictionary<int, List<int>>();
        }
        /* {1--> {2,3   }}
         * {2-->{1   }}
         * {3--->{1  }}
         * {4--->{  }}
         */
        public void AddVertex(int vertex)
        {
            if(!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<int>();// holds the adjacent vertices
            }
        }
        //3,4
        public void AddEdge(int vertex1,int vertex2)
        {
            // if the vertex does not exist, we create one and also the list
            if(!adjList.ContainsKey(vertex1))
            {
                AddVertex(vertex1);
            }
            if(!adjList.ContainsKey(vertex2))
            {
                AddVertex(vertex2);
            }
            adjList[vertex1].Add(vertex2);
           // adjList[vertex2].Add(vertex1);//undirected graph
        }
        public void Display()
        {
            foreach (var vertex in adjList)
            {
                Console.Write(vertex.Key + " -> ");
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
