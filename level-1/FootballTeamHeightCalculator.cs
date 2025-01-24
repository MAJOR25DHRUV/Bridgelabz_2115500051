using System;

public class FootballTeamHeightCalculator
{
    public static void CalculateTeamMeanHeight()
    {
        // Array to store player heights
        double[] heights = new double[11];
        
        // Variable to store total height
        double totalHeight = 0.0;

        // Input heights for 11 players
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter height for player " + (i + 1) + ": ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
            
            // Add to total height
            totalHeight += heights[i];
        }

        // Calculate mean height
        double meanHeight = totalHeight / 11;

        // Display mean height
        Console.WriteLine("Mean height of the football team: " + meanHeight);
    }

    public static void Main()
    {
        CalculateTeamMeanHeight();
    }
}