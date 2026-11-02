using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDemo1
{
    internal class AdjacencyMatrixGraph
    {
        private int[,] adjacencyMatrix;
        private int vertexCount;
        public AdjacencyMatrixGraph(int size)
        {
            adjacencyMatrix = new int[size, size];
            vertexCount = size;
        }
        public void AddEdge(int vertex1, int vertex2, int weight = 1)
        {
            adjacencyMatrix[vertex1, vertex2] = weight;// use this only if directed graph
            adjacencyMatrix[vertex2, vertex1] = weight; // For undirected graph
        }
        public void RemoveEdge(int vertex1, int vertex2)
        {
            adjacencyMatrix[vertex1, vertex2] = 0;// use this only if directed graph
           adjacencyMatrix[vertex2, vertex1] = 0; // For undirected graph
        }
        public void Display()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    Console.Write(adjacencyMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
