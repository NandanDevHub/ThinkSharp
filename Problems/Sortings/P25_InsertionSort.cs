namespace ThinkSharp.Problems
{
    // Insertion Sort is a simple sorting algorithm that builds the final sorted array one item at a time.
    // It is much less efficient on large lists than more advanced algorithms such as quicksort, heapsort, or merge sort.
    // However, it has some advantages such as simple implementation, efficient for small data sets, and more efficient in practice than most other simple quadratic algorithms such as selection sort or bubble sort.
    // The algorithm works by iterating through the input array and growing a sorted output list.
    // At each iteration, it removes one element from the input data, finds the location it belongs within the sorted list, and inserts it there.
    // It repeats this process until no input elements remain.

    class InsertionSort
    {
        public static void Run()
        {
            Console.WriteLine("\n=========================================");
            Console.WriteLine("        PROBLEM 25: Insertion Sort         ");
            Console.WriteLine("=========================================\n");

            Console.WriteLine("Enter numbers separated by spaces:");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            var numbers = input.Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Unsorted Array: " + string.Join(",", numbers));

            for (var i = 1; i < numbers.Length; i++)
            {
                int kValue = numbers[i];
                int jthIndex = i - 1;

                while (jthIndex >= 0 && numbers[jthIndex] > kValue)
                {
                    numbers[jthIndex + 1] = numbers[jthIndex];
                    jthIndex--;
                }
                numbers[jthIndex + 1] = kValue;

            }

            Console.WriteLine("Sorted Array: " + string.Join(",", numbers));

        }
    }
}