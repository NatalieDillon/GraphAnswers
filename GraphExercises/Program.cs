using System.Diagnostics;
using GraphExercises.Classes;

namespace GraphExercises
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, Graph!");

            // Test matrix implementation
            MatrixGraph matrix = new();
            TestGraph(matrix);
            Console.WriteLine();

            // Test adjacency list implementation
            AdjacencyListGraph adjList = new();
            TestGraph(adjList);

        }

        private static void TestGraph(IGraph graph)
        {

            graph.AddEdge(new Edge("A", "B", 2));
            graph.AddEdge(new Edge("A", "C", 9));
            graph.AddEdge(new Edge("A", "D", 3));
            graph.AddEdge(new Edge("B", "E", 2));
            graph.AddEdge(new Edge("C", "A", 9));
            graph.AddEdge(new Edge("D", "A", 3));

            graph.AddEdge(new Edge("D", "B", 6));
            graph.AddEdge(new Edge("D", "C", 7));
            graph.AddEdge(new Edge("D", "E", 1));
            graph.AddEdge(new Edge("D", "F", 5));
            graph.AddEdge(new Edge("E", "F", 8));

            Console.WriteLine(graph.Display());
            Console.WriteLine(graph.IsConnected("D", "B"));
            Console.WriteLine(graph.IsConnected("C", "E"));
            Debug.Assert(graph.IsConnected("D", "B"));
            Debug.Assert(!graph.IsConnected("C", "E"));

            Console.WriteLine($"Neighbours of D: {string.Join(",", graph.Neighbours("D"))}");
        }
    }
}