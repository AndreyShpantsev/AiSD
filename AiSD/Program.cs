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

            //Вызов и вывод сортировок
            /*Console.WriteLine("Hello World!");
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 10);
            }
            //QuickSort(mass, 0, mass.Length - 1);
            //mass = CountingSort(mass, 10);
            mass = GnomeSort(mass);
            foreach (var m in mass)
                Console.WriteLine(m);
            Console.ReadLine();
            */

        }
        /*//Быстрая сортировка
        #region QuickSort
        public static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }
        public static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    Swap(array, marker, i);
                    marker += 1;
                }
            }
            return marker - 1;
        }
        public static void Swap(int[] arr, int i, int j)
        {
            int k = arr[i];
            arr[i] = arr[j];
            arr[j] = k;
        }
        #endregion
        //Сортировка слиянием
        #region MergeSort
        static int[] Merge_Sort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return Merge(Merge_Sort(massive.Take(mid_point).ToArray()), Merge_Sort(massive.Skip(mid_point).ToArray()));
        }

        static int[] Merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                        merged[i] = mass2[b++];
                    else //if int go for
                        merged[i] = mass1[a++];
                else if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }
        #endregion
        //Сортировка подсчетом !! Работает только с неотрицательными числами и разброс рандома значений должен быть не больше указанного вторым параметром числа.
        #region CountingSort
        public static int[] CountingSort(int[] array, int k)
        {
            int[] countArray = new int[k];

            for (int i = 0; i < array.Length; i++)
            {
                countArray[array[i]]++;
            }

            for (int i = 1; i < k; i++)
            {
                countArray[i] = countArray[i] + countArray[i - 1];
            }

            int[] resultArray = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                resultArray[countArray[array[i]] - 1] = array[i];
                countArray[array[i]] = countArray[array[i]] - 1;
            }

            return resultArray;
        }
        #endregion
        //Гномья сортировка
        #region GnomeSort
        static int[] GnomeSort(int[] array)
        {
            int i = 1;
            int j = 2;
            while (i < array.Length)
            {
                if (array[i - 1] < array[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(array, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
            return array;
        }
        #endregion
        */
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
