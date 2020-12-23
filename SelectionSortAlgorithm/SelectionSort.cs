using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortAlgorithm {
      public class SelectionSort {
            public int[] UnstableSelectionSort(int[] numberList) {
                  int length = numberList.Length;

                  for (int i = 0; i < length - 1; i++) {
                        int min = i;
                        for (int j = 0; j < length; j++) {
                              if (numberList[j] < numberList[min])
                                    min = j;
                        }

                        int temp = numberList[min];
                        numberList[min] = numberList[i];
                        numberList[i] = temp;
                  }
                  return numberList;
            }

            public int[] StableSelectionSort(int[] numberList) {
                  int length = numberList.Length;

                  for (int i = 0; i < length - 1; i++) {
                        int min = i;
                        for (int j = 0; j < length; j++) {
                              if (numberList[min] > numberList[j])
                                    min = j;
                        }

                        int temp = numberList[min];
                        while(min > i) {
                              numberList[min] = numberList[min - 1];
                              min--;
                        }
                        numberList[i] = temp;
                  }
                  return numberList;
            }
      }
}
