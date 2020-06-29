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
        /// The number of vertices (nodes) in the graph, limited to int.
        /// </summary>
        internal int numVertices;

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
            // Check for at least 1 vertex.
            if (numVertices < 1)
            {
                throw new ArgumentOutOfRangeException("Graph must have at least 1 vertex.");
            }

            this.numVertices = numVertices;
            adj = new List<int>[numVertices];

            for (int i = 0; i < numVertices; ++i)
            {
                adj[i] = new List<int>();
            }
        }

        /// <summary>
        /// Creates an edge between the given vertices. Vertices may have edges to themselves.
        /// </summary>
        /// <param name="vertex1">The vertex to which to add a directed edge</param>
        /// <param name="vertex2">The vertex to which an edge is directed</param>
        internal void AddEdge(int vertex1, int vertex2)
        {
            // Check for out of range vertex1.
            if (vertex1 < 0 || vertex1 >= numVertices)
            {
                throw new ArgumentOutOfRangeException($"The first parameter must be at least 0 and less than {numVertices}.");
            }

            // Check for out of range vertex2.
            if (vertex2 < 0 || vertex2 >= numVertices)
            {
                throw new ArgumentOutOfRangeException($"The second parameter must be at least 0 and less than {numVertices}.");
            }

            adj[vertex1].Add(vertex2);
        }

        /// <summary>
        /// Prints the vertices breadth first
        /// </summary>
        /// <param name="startingVertex">Vertex where printing starts</param>
        internal void PrintVerticesBreathFirst(int startingVertex)
        {
            // Check for out of bounds startingVertex
            if (startingVertex < 0 || startingVertex >= numVertices)
            {
                Console.WriteLine($"Parameter must be at least 0 and less than {numVertices}.");
                return;
            }
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
