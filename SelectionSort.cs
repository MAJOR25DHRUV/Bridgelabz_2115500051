using System;

class SelectionSortExample
{
    static void SelectionSort(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
                if (scores[j] < scores[minIndex])
                    minIndex = j;

            (scores[i], scores[minIndex]) = (scores[minIndex], scores[i]);
        }
    }

    static void Main()
    {
        int[] scores = { 88, 95, 70, 60, 92 };
        SelectionSort(scores);
        Console.WriteLine("Sorted Exam Scores: " + string.Join(", ", scores));
    }
}
