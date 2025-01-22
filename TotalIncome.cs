using System;

class TotalIncome
{
    public static void Main(string[] args)
    {
        double salary = 50000; // Example salary
        double bonus = 10000; // Example bonus
        CalculateIncome(salary, bonus); // Calling method to calculate total income
    }

    // Method to calculate total income and print the result
    static void CalculateIncome(double salary, double bonus)
    {
        double totalIncome = salary + bonus; // Adding salary and bonus
        // Displaying the result
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}
