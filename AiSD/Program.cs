using AiSD.Graphs;
using AiSD.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Граф на основе матрицы смежности
            /*var graph = new Graph();

            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v5, v6);
            graph.AddEdge(v6, v5);
            GetMatrix(graph);
            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            GetVertex(graph, v5);
            GetVertex(graph, v6);
            GetVertex(graph, v7);
            Console.WriteLine(graph.Wave(v1, v5));
            Console.WriteLine(graph.Wave(v2, v4));

            Console.ReadKey();*/

            /*//Кольцевой список
            var circularList = new CircularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach(var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // Удаление из списка
            circularList.Delete(3);
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadKey();*/

            /* //Двусвязный список
            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);
            foreach(var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Удаление элемента списка
            duplexList.Delete(3);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Реверс списка
            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.ReadLine();*/

            /* //Бинарное дерево
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            tree.Add(4);
            
            //Префиксный обход дерева
            foreach (var item in tree.Preorder())
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();

            //Постфиксный обход дерева
            foreach (var item in tree.Postorder())
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();

            //Инфиксный обход дерева
            foreach (var item in tree.Inorder())
            {
                Console.Write(item + ", ");
            }

            Console.ReadLine();*/

        }
        //вывод смежных вершин
        /*private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number + ": ");
            foreach (var v in graph.GetVertexLists(vertex))
            {

                Console.Write(v.Number + ", ");
            }
            Console.WriteLine();
        }
        //вывод матрицы смежности
        private static void GetMatrix(Graph graph)
        {
            int[,] matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }*/
    }
}
