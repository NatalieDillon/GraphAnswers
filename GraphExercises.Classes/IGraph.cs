namespace GraphExercises.Classes
{
    public interface IGraph
    {
        bool IsConnected(string startVertex, string endVertex);

        List<string> Neighbours(string startVertex);

        string Display();

        void AddVertex(string vertex);

        void AddEdges(List<Edge> edges);

        void AddEdge(Edge edge);
    }
}