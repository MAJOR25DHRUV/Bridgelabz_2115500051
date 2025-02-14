using System;

class QuickSortExample
{
    static void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(prices, low, high);
            QuickSort(prices, low, pi - 1);
            QuickSort(prices, pi + 1, high);
        }
    }

    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                (prices[i], prices[j]) = (prices[j], prices[i]);
            }
        }
        (prices[i + 1], prices[high]) = (prices[high], prices[i + 1]);
        return i + 1;
    }

    static void Main()
    {
        int[] prices = { 400, 200, 600, 100, 300 };
        QuickSort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted Product Prices: " + string.Join(", ", prices));
    }
}
