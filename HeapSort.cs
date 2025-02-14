using System;

class HeapSortExample
{
    static void HeapSort(int[] salaries)
    {
        int n = salaries.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(salaries, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            (salaries[0], salaries[i]) = (salaries[i], salaries[0]);
            Heapify(salaries, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i, left = 2 * i + 1, right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }

    static void Main()
    {
        int[] salaries = { 50000, 75000, 60000, 45000, 90000 };
        HeapSort(salaries);
        Console.WriteLine("Sorted Salaries: " + string.Join(", ", salaries));
    }
}
