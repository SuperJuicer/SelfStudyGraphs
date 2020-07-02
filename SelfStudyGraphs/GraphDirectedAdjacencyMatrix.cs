using System;
namespace SelfStudyGraphs
{
    class GraphDirectedAdjacencyMatrix
    {
        private bool[,] adj;
        private int numVertices;

        public GraphDirectedAdjacencyMatrix(int numVertices)
        {
            // Check for at least 1 vertex.
            if (numVertices < 1)
            {
                throw new ArgumentOutOfRangeException("Graph must have at least 1 vertex.");
            }

            this.numVertices = numVertices;
        }
    }
}
