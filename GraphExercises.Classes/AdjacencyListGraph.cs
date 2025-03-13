using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExercises.Classes
{
    public class AdjacencyListGraph : IGraph
    {
        // Uses a dictionary of dictionaries
        private readonly Dictionary<string, Dictionary<string, double>> _graph = [];

        public void AddEdge(string startVertex, string endVertex, double weight)
        {
            _graph.TryAdd(startVertex, []); // Add the start vertex if it isn't there
			_graph.TryAdd(endVertex, []); // Add the end vertex if it isn't there
            _graph[startVertex].TryAdd(endVertex, weight); // Add the edge to the adjacency list of the start vertex
        }

        public string Display()
        {
            StringBuilder sb = new();
            foreach (var vertex in _graph)
            {
                string entry = $"{vertex.Key}: ";
                entry += "[";
                foreach (var adjacencyList in vertex.Value)
                {
                   entry += $"{adjacencyList.Key}:{adjacencyList.Value}, ";
                   
                }
                entry = entry.TrimEnd().TrimEnd(',');
                entry += "]\n";
                sb.Append(entry);
            }
            return sb.ToString();
        }

        public bool HasEdge(string startVertex, string endVertex)
        {
            bool hasEdge = false;
            if (_graph.TryGetValue(startVertex, out var adjacencyList))
            {
                hasEdge = adjacencyList.ContainsKey(endVertex);
            }
            return hasEdge;
        }

        public List<string> Neighbours(string vertex)
        {
            List<string> neighbours = [];
            if (_graph.TryGetValue(vertex, out var adjacencyList))
            {
                neighbours.AddRange(adjacencyList.Keys);
            }
            return neighbours;
        }

       
    }
}
