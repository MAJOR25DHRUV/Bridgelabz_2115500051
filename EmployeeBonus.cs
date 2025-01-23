using System;  // Importing the System namespace to use Console

public class EmployeeBonus
{
    // Method to calculate the bonus based on years of service
    public static void CalculateBonus(double salary, int yearsOfService)
    {
        // Check if years of service is greater than 5
        if (yearsOfService > 5)
        {
            // Calculate 5% bonus
            double bonus = salary * 0.05;
            // Output the result
            Console.WriteLine("The bonus is: " + bonus);
        }
        else
        {
            Console.WriteLine("No bonus as the years of service are less than or equal to 5.");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Example input: salary and years of service
        double salary = 50000;  // Replace with user input if needed
        int yearsOfService = 6;  // Replace with user input if needed

        // Call the method to calculate the bonus
        CalculateBonus(salary, yearsOfService);
    }
}
