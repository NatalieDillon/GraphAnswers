using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExercises.Classes
{
    public class Edge
    {
        public string StartVertex { get; }
        public string EndVertex { get; }

        public double Weight { get; }

        public Edge(string startVertex, string endVertex, double weight = 1)
        {
            StartVertex = startVertex;
            EndVertex = endVertex;
            Weight = weight;
        }
    }
}
