using System;

namespace SelfStudyGraphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Graphs!");

            var graph1 = new GraphDirectedAdjacencyList(4);
            graph1.AddEdge(0, 1);
            graph1.AddEdge(0, 2);
            graph1.AddEdge(1, 2);
            graph1.AddEdge(2, 0);
            graph1.AddEdge(2, 3);
            graph1.AddEdge(3, 3);

            // A graph with no vertices throws an exception:
            // var graph2 = new GraphDirectedAdjacencyList(0);

            // Trying to add impossible edges throws exceptions:
            // graph1.AddEdge(-1, 0);
            // graph1.AddEdge(graph1.numVertices, 0);
            // graph1.AddEdge(0, -1);
            // graph1.AddEdge(0, graph1.numVertices);

            Console.WriteLine("\nHere's a breadth first traversal of a directed graph with an adjancency list and 4 vertices starting from vertex 2:");
            graph1.PrintVerticesBreathFirst(2);

            Console.WriteLine("\n\nSame graph, same method, starting vertex is -1:");
            graph1.PrintVerticesBreathFirst(-1);

            Console.WriteLine($"\n\nSame graph, same method, starting vertex is {graph1.numVertices}:");
            graph1.PrintVerticesBreathFirst(graph1.numVertices);

            // Produce a Null Reference Exception that doesn't reach the method.
            // graph1 = null;
            // graph1.PrintVerticesBreathFirst(0);

            Console.WriteLine();
        }
    }
}
