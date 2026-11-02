using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTraversaldemo
{
    internal class MyGraph
    {
        private int[,] adjMatrix;
        private int numVertices;
        private int[] visited;
        public MyGraph(int size)
        {
            adjMatrix = new int[size, size];
            numVertices = size;
            visited = new int[size];
        }
        // 1->2
        // 2->1
        public void AddEdge(int source, int destination)
        {
            adjMatrix[source, destination] = 1;
           // adjMatrix[destination, source] = 1; // For undirected graph
        }
        public void RemoEdge(int source, int destination)
        {
            adjMatrix[source, destination] = 0;
            // adjMatrix[destination, source] = 0; // For undirected graph
        }
        public void PrintGraph()
        {
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(adjMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //level order traversal
        public void BFS(int start)
        {
            int i=start;
            Queue<int> queue = new Queue<int>();
            Console.Write(i + " ");
            visited[i] = 1;// mark as visited
            queue.Enqueue(i);
            while(!(queue.Count==0))
            {
                i = queue.Dequeue();
                for(int j=0; j<numVertices; j++)
                {
                    if (adjMatrix[i, j] == 1 && visited[j] == 0)//not visited
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;// mark as visited
                        queue.Enqueue(j);
                    }
                }
            }
            Console.WriteLine();
        }

        public void ResetVisited()
        {
            for (int i = 0; i < numVertices; i++)
            {
                visited[i] = 0;
            }
        }
        public void DFS(int start)
        {
            if (visited[start]==0)
            {
                Console.Write(start + " ");
                visited[start] = 1;// mark as visited
                for(int j = 0; j < numVertices; j++)
                {
                    if (adjMatrix[start, j] == 1 && visited[j] == 0)//not visited
                    {
                        DFS(j);
                    }
                }
            }
        }
    }
}
