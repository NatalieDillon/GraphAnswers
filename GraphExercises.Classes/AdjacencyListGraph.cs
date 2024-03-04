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
        private readonly Dictionary<string, Dictionary<string, double>> _graph = new();

        public void AddEdge(string startVertex, string endVertex, double weight)
        {
            Dictionary<string, double> neighbours;
            // Make sure start vertex is added to dictionary
            if (_graph.ContainsKey(startVertex))
            {
                neighbours = _graph[startVertex];
            }
            else
            {
                neighbours = new Dictionary<string, double>();
                _graph.Add(startVertex, neighbours);
            }
            // Make sure end vertex is added to adjacency list
            if (neighbours.ContainsKey(endVertex))
            {
                neighbours[endVertex] = weight;
            }
            else
            {
                neighbours.Add(endVertex, weight);
            }
            // Make sure end vertex is added to the dictionary
            if (!_graph.ContainsKey(endVertex))
            {
                _graph.Add(endVertex, new Dictionary<string, double>());
            }
        }

        public void AddVertex(string vertex)
        {
            if (!_graph.ContainsKey(vertex))
            {
                _graph.Add(vertex, new Dictionary<string, double>());
            }
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

        public bool IsConnected(string startVertex, string endVertex)
        {
            if (_graph.ContainsKey(startVertex))
            {
                var values = _graph[startVertex];
                return values.Keys.FirstOrDefault(k => k.Equals(endVertex)) != null;
            }
            return false;
        }

        public List<string> Neighbours(string vertex)
        {
            List<string> neighbours = new();
            if (_graph.ContainsKey(vertex))
            {
                neighbours.AddRange(_graph[vertex].Keys);
            }
            return neighbours;
        }

       
    }
}
