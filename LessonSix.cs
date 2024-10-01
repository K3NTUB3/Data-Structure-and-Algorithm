using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_and_Algorithm
{
    internal class LessonSix
    {
        public static void Lesson6()
        {
            Graph graph = new Graph();

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);

            graph.DisplayGraph();
        }
    }
    public class Graph
    {
        private Dictionary<int, List<int>> adjList;

        public Graph()
        {
            adjList = new Dictionary<int, List<int>>();
        }

        public void AddVertex(int vertex)
        {
            if (!adjList.ContainsKey(vertex))
            {
                adjList[vertex] = new List<int>();
            }
        }

        public void AddEdge(int vertex1, int vertex2)
        {
            if (!adjList.ContainsKey(vertex1)) AddVertex(vertex1);
            if (!adjList.ContainsKey(vertex2)) AddVertex(vertex2);

            adjList[vertex1].Add(vertex2);
            adjList[vertex2].Add(vertex1); 
        }

        public void DisplayGraph()
        {
            foreach (var vertex in adjList)
            {
                Console.Write(vertex.Key + " -> ");
                foreach (var neighbor in vertex.Value)
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
