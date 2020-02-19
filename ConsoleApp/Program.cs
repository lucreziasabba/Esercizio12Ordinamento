using Ordinamento;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensioni = { 10, 20, 50, 100, 500, 1000, 5000, 10000, 15000, 20000, 25000, 30000 };
            using (StreamWriter w = new StreamWriter("start.csv", false, Encoding.UTF8))
            {
                w.WriteLine("Algoritmo;Dimensione;Tempo");
                foreach (int dim in dimensioni)
                {
                    int[] array = new int[dim];
                    Random r = new Random();
                    for (int i = 0; i < dim; i++)
                        array[i] = r.Next(0, 100);
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    BubbleSort.Ordinamento(array);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"Bubble Sort;{dim};{elapsed}");
                    Console.WriteLine($"Bubble Sort;{dim};{elapsed}");
                }
                foreach (int dim in dimensioni)
                {
                    int[] array = new int[dim];
                    Random r = new Random();
                    for (int i = 0; i < dim; i++)
                        array[i] = r.Next(0, 100);
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    InsertSort.Ordinamento(array);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"Insertion Sort;{dim};{elapsed}");
                    Console.WriteLine($"Insertion Sort;{dim};{elapsed}");
                }
                foreach (int dim in dimensioni)
                {
                    int[] array = new int[dim];
                    Random r = new Random();
                    for (int i = 0; i < dim; i++)
                        array[i] = r.Next(0, 100);
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    SelectionSort.Ordinamento(array);
                    s.Stop();
                    long elapsed = s.ElapsedMilliseconds;
                    w.WriteLine($"Selection Sort;{dim};{elapsed}");
                    Console.WriteLine($"Selection Sort;{dim};{elapsed}");
                }
                w.Flush();
            }
        }
    }
}
