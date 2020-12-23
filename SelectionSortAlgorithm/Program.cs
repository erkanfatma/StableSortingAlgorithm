using System;
using System.Diagnostics;

namespace SelectionSortAlgorithm {
      class Program {
            static void Main(string[] args) {
                  SelectionSort selectionSort = new SelectionSort();
                  Stopwatch watch = new Stopwatch();

                  int[] numbers = { 4, 7, 12, 5 ,3 ,2, 4, 1, 6, 22, 11, 10, 9, 23};

                  Console.WriteLine("UNSTABLE SELECTION SORT");
                  watch.Start();
                  int[] unstableSort = selectionSort.UnstableSelectionSort(numbers);
                  for (int i = 0; i < numbers.Length; i++) {
                        Console.WriteLine(unstableSort[i] + " ");
                  }
                  watch.Stop();
                  Console.WriteLine($"Elapsed Time: {watch.ElapsedMilliseconds} ms \n");

                  Console.WriteLine("--------------------");

                  Console.WriteLine("STABLE SELECTION SORT");
                  watch.Restart();
                  int[] stableSort = selectionSort.StableSelectionSort(numbers);
                  for (int i = 0; i < numbers.Length; i++) {
                        Console.WriteLine(stableSort[i]+ " ");
                  }
                  watch.Stop();
                  Console.WriteLine($"Elapsed Time: {watch.ElapsedMilliseconds} ms \n");
                  Console.Read();
            }
      }
}
