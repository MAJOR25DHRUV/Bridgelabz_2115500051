using System;

class CountingSortExample
{
    static void CountingSort(int[] ages)
    {
        int max = 18, min = 10;
        int range = max - min + 1;
        int[] count = new int[range];

        foreach (int age in ages)
            count[age - min]++;

        int index = 0;
        for (int i = 0; i < range; i++)
            while (count[i]-- > 0)
                ages[index++] = i + min;
    }

    static void Main()
    {
        int[] ages = { 12, 14, 10, 18, 13, 11, 16, 15 };
        CountingSort(ages);
        Console.WriteLine("Sorted Ages: " + string.Join(", ", ages));
    }
}
