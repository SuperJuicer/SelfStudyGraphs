using System;
using System.Collections.Generic;

namespace SelfStudyGraphs
{
    /// <summary>
    /// Represents a directed graph with an adjacency list
    /// </summary>
    class GraphDirectedAdjacencyList
    {
        /// <summary>
        /// The number of vertices (nodes) in the graph
        /// </summary>
        private int numVertices;

        /// <summary>
        /// The adjacency array of lists
        /// </summary>
        private List<int>[] adj;

        /// <summary>
        /// Constructs a new graph with the given number of vertices
        /// </summary>
        /// <param name="numVertices">The total number of vertices (nodes) in the graph</param>
        internal GraphDirectedAdjacencyList(int numVertices)
        {
            this.numVertices = numVertices;
            adj = new List<int>[numVertices];

            for (int i = 0; i < numVertices; ++i)
            {
                adj[i] = new List<int>();
            }
        }

        /// <summary>
        /// Creates an edge between the given vertices
        /// </summary>
        /// <param name="vertex1">The vertex to which to add a directed edge</param>
        /// <param name="vertex2">The vertex to which an edge is directed</param>
        internal void AddEdge(int vertex1, int vertex2)
        {
            adj[vertex1].Add(vertex2);
        }

        /// <summary>
        /// Prints the vertices breadth first
        /// </summary>
        /// <param name="startingVertex">Vertex where printing starts</param>
        internal void PrintVerticesBreathFirst(int startingVertex)
        {
            // The graph may have a cycle, so store visited vertices.
            bool[] visited = new bool[numVertices];
            visited[startingVertex] = true;

            // Queue for breadth
            var q = new Queue<int>();
            q.Enqueue(startingVertex);

            // Get traversing and printing!
            while (q.Count != 0)
            {
                // Dequeue and print
                int currentDequeuedVertex = q.Dequeue();
                Console.Write(currentDequeuedVertex + " ");

                // Using adjacency list
                foreach (int neighbor in adj[currentDequeuedVertex])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        q.Enqueue(neighbor);
                    }
                }
            }
        }
    }
}
