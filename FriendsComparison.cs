using System;

public class FriendsComparison
{
    public static void Main(string[] args)
    {
        // Arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = {"Amar", "Akbar", "Anthony"};
        
        // Get input from user
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter age for " + names[i] + ":");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter height for " + names[i] + ":");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        
        // Find youngest and tallest
        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);
        
        // Display results
        Console.WriteLine("Youngest friend is: " + names[youngestIndex]);
        Console.WriteLine("Tallest friend is: " + names[tallestIndex]);
    }
    
    public static int FindYoungest(int[] ages)
    {
        // Find index of minimum age
        int minIndex = 0;
        for(int i = 1; i < ages.Length; i++)
        {
            if(ages[i] < ages[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }
    
    public static int FindTallest(double[] heights)
    {
        // Find index of maximum height
        int maxIndex = 0;
        for(int i = 1; i < heights.Length; i++)
        {
            if(heights[i] > heights[maxIndex])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}