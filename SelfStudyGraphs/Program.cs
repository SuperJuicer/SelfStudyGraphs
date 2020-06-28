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

            Console.WriteLine("\nHere's a breadth first traversal of graph1 starting from vertex 2:");
            graph1.PrintVerticesBreathFirst(2);

            Console.WriteLine();
        }
    }
}
