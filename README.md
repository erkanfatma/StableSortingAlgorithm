## Stable Sorting Algorithm 
Stable is stand for determined or unchanging (constant) situations.
Stable algorithm has two important features:
The first one is, it preserves the order of elements with equal keys.
The second one is, it avoids magnifying small errors.

The stability of a sorting algorithm is about how the algorithm treats repeated elements. Stable sorting protects the location of equal elements relative to one another. Unstable sorting algorithms can not protect the relative order of equal elements. Stable sorting is important when equal elements occur in the list. If the list already has an order, sorting depends on another key must protect the order. If any equal elements occur, stability is mandatory. 
For instance, if you need to sort (2, 4, 5, 7, 8, 10, 10). After if an algorithm does not change the order of last two elements then the algorithm is stable. However, if the algorithm swaps these two elements, then it becomes an unstable algorithm even the result of resorting is the same with first sorting result. 
This difference is more understandable when the algorithm sorts key-value pairs by their keys. If the algorithm is stable, there is one output exists as a solution. Discuss an example, we have 
- (10,1), (3,4), (3,1), (5,2), (6,7)
and the algorithm sort the above key-value pairs in the increasing order of keys. Then there are two possible outputs for this algorithm as shown below:
- (3,4), (3,1), (5,2), (6,7), (10,1)
- (3,1), (3,4), (5,2), (6,7), (10,1)

The sorting algorithm that produces the first output “ (3,4), (3,1), (5,2), (6,7), (10,1) ” is known as a stable sorting algorithm. This is because the original order of equal keys order is the same as the given input. The order of (3,4) and (3,1) do not change. However, if the algorithm is unstable then the result will be the second solution “ (3,1), (3,4), (5,2), (6,7), (10,1) ”. In this case, the order of the result with equal keys is not maintained in sorted order.
If all keys are different then this distinction is not necessary. However, if equal keys exist in the list, then a sorting algorithm is stable if there are two data (let me say A and B for these elements) with the same key, and A appears before B in the input list, then A will always appear before B in the output list.

### Stable Sorting Algorithms
- Merge Sort
- Insertion Sort
- Bubble Sort
- Binary Tree Sort
- Timsort
- Counting Sort 
- Block Sort
- Bucket Sort
- Cascade Merge Sort 
- Cubesort
- Gnome Sort
- Interpolation Sort
- Pigenhole Sort
-	Proxmap Sort
-	Odd-even Sort
-	Oscillating Merge Sort
-	Cocktail Shaker Sort

### Unstable Sorting Algorithms
-	Quick Sort
-	Heap Sort
-	Selection Sort 
-	Intro Sort 
-	Shell Sort
-	Cycle Sort
-	Library Sort
-	Patience Sorting
-	Smooth Sort
-	Tournament Sort
-	Comb Sort
-	UnShuffle Sort
-	Flash Sort
-	Burst Sort
-	Spread Sort

## Selection Sort
Selection sort is an unstable algorithm. It finds the minimum value from the unsorted array part and put this value at the beginning of the array. The algorithm has two subarrays in the input array. One of the subarrays is sorted and another one is not sorted subarray. The time complexity of the selection sort algorithm is O(n2).
The algorithm works like that:
1. Select the minimum element from the unsorted subarray,
2. Move this element to the sorted subarray.

## Achievements
Any sorting algorithm that is not stable can be implemented as a stable algorithm. It can be modified by changing the key comparison operation. The selection sort algorithm finds the minimum number in the list and inserts it in the correct location using swap operation. This operation is an unstable sort. The selection sort algorithm will be stable without a swap operation. Instead of using a swap operation, the selected minimum element placed its location without swap operation. It can place the selected number to the location like an insertion sort algorithm.
In this implementation, there are two methods defined to compare an unstable sorting algorithm with a stable sorting algorithm using selection sort algorithm. The difference between the two code is so clear and simple. Unstable selection sort algorithm contains swap operation to find the best position for selected number. On the other hand, stable selection sort algorithm does not use the swap operation to find the correct location for the selected number. It inserts the element to the correct position. As a result, the swap operation makes code execution slower.

