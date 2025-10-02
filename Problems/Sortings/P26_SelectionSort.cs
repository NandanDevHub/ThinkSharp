namespace ThinkSharp.Problems
{
    // Selection Sort is a simple sorting algorithm that divides the input list into two parts: a sorted and an unsorted region.
    // It repeatedly selects the smallest (or largest, depending on the sorting order) element from
    // the unsorted region and moves it to the end of the sorted region.
    // The algorithm maintains two subarrays within the original array:
    // 1. The subarray which is already sorted.
    // 2. The remaining subarray which is unsorted.
    // The algorithm iterates through the unsorted subarray, finds the minimum element,
    // and swaps it with the leftmost unsorted element, moving the boundary of the sorted
    // subarray one element to the right.
    // This process is repeated until the entire array is sorted.

    class SelectionSort
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 26: Selection Sort         ");
            Console.WriteLine("=========================================\n");

        }
    }           
}