using System; // Importing System namespace for basic functionalities

class Profit // Declaring the class for profit and loss calculation
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        double costPrice = 129; // Cost Price in INR
        double sellingPrice = 191; // Selling Price in INR
        CalculateProfitAndLoss(costPrice, sellingPrice); // Calling the method to calculate profit and loss
    }

    // Method to calculate and display profit, loss, and their percentage
    static void CalculateProfitAndLoss(double costPrice, double sellingPrice)
    {
        double profit = sellingPrice - costPrice; // Calculating the profit
        double profitPercentage = (profit / costPrice) * 100; // Calculating profit percentage
        // Displaying the result in print statement
        Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice);
        Console.WriteLine("The Profit is INR " + profit.ToString("F2") + " and the Profit Percentage is " + profitPercentage.ToString("F2") + "%");
    }
}
