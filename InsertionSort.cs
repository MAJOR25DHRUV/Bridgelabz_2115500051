using System;

class InsertionSortExample
{
    static void InsertionSort(int[] empIDs)
    {
        int n = empIDs.Length;

        for (int i = 1; i < n; i++)
        {
            int key = empIDs[i];
            int j = i - 1;

            // Move elements of empIDs[0..i-1], that are greater than key,
            // one position ahead of their current position
            while (j >= 0 && empIDs[j] > key)
            {
                empIDs[j + 1] = empIDs[j];
                j--;
            }
            empIDs[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] empIDs = { 102, 101, 104, 103, 100 };
        InsertionSort(empIDs);
        Console.WriteLine("Sorted Employee IDs: " + string.Join(", ", empIDs));
    }
}
