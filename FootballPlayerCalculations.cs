using System;

class FootballPlayerCalculations
{
    static void Main(string[] args)
    {
        // Array initialization to store the heights of 11 players
        int[] heights = new int[11];

        Console.WriteLine("Enter the heights of " + heights.Length + " players:");

        // Loop to take user input for each player's height
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter the height of player no. " + (i + 1) + ": ");
            // Convert the input string to an integer and store it in the array
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Display calculated values using respective methods
        Console.WriteLine("The mean height of all the players: " + MeanHeight(heights));
        Console.WriteLine("The sum of height of all the players: " + SumHeight(heights));
        Console.WriteLine("The shortest height of all the players: " + ShortestHeight(heights));
        Console.WriteLine("The tallest height of all the players: " + TallestHeight(heights));
    }

    // Method to calculate the mean height of the players
    static double MeanHeight(int[] heights)
    {
        int sum = 0;

        // Calculate the sum of all heights
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }

        // Return the mean by dividing the sum by the number of players
        return (double)sum / heights.Length;
    }

    // Method to calculate the total sum of all player heights
    static int SumHeight(int[] heights)
    {
        int sum = 0;

        // Loop through each height and add it to the sum
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }

        // Return the total sum
        return sum;
    }

    // Method to find the shortest height among the players
    static int ShortestHeight(int[] heights)
    {
        // Initialize the shortest height with the maximum possible integer value
        int shortest = int.MaxValue;

        // Iterate through the heights array
        for (int i = 0; i < heights.Length; i++)
        {
            // Update the shortest height if the current height is smaller
            if (shortest > heights[i])
            {
                shortest = heights[i];
            }
        }

        // Return the shortest height
        return shortest;
    }

    // Method to find the tallest height among the players
    static int TallestHeight(int[] heights)
    {
        // Initialize the tallest height with the minimum possible integer value
        int tallest = int.MinValue;

        // Iterate through the heights array
        for (int i = 0; i < heights.Length; i++)
        {
            // Update the tallest height if the current height is larger
            if (tallest < heights[i])
            {
                tallest = heights[i];
            }
        }

        // Return the tallest height
        return tallest;
		
    }
}
