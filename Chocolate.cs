using System;

class Chocolate
{
    public static void Main(string[] args)
    {
        int numberOfChocolates = 100; // Example number of chocolates
        int numberOfChildren = 12; // Example number of children
        DistributeChocolates(numberOfChocolates, numberOfChildren); // Calling method to distribute chocolates
    }

    // Method to distribute chocolates and display results
    static void DistributeChocolates(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesPerChild = numberOfChocolates / numberOfChildren; // Number of chocolates each child gets
        int remainingChocolates = numberOfChocolates % numberOfChildren; // Remaining chocolates after distribution
        // Displaying the result
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + " and the number of remaining chocolates is " + remainingChocolates);
    }
}
