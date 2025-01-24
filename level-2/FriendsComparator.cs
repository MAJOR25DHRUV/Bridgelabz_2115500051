using System;

public class FriendsComparator
{
    public static void CompareFriends()
    {
        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = {"Amar", "Akbar", "Anthony"};

        // Input ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age for " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height for " + names[i] + ": ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Find youngest friend
        int youngestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        // Find tallest friend
        int tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        // Display results
        Console.WriteLine("Youngest friend: " + names[youngestIndex] + " with age " + ages[youngestIndex]);
        Console.WriteLine("Tallest friend: " + names[tallestIndex] + " with height " + heights[tallestIndex]);
    }

    public static void Main()
    {
        CompareFriends();
    }
}