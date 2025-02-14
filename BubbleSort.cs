using System;

class BubbleSortExample
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        // Traverse through all elements
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if the current element is greater than the next
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            // If no swaps were made, the array is already sorted
            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] marks = { 75, 85, 62, 90, 55, 80 };
        BubbleSort(marks);
        Console.WriteLine("Sorted Marks: " + string.Join(", ", marks));
    }
}
