using System;

public class EmployeeBonusCalculator
{
    public static void CalculateEmployeeBonus()
    {
        // Arrays to store employee details
        double[] oldSalaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonusAmounts = new double[10];
        double[] newSalaries = new double[10];

        // Variables to track totals
        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        // Input employee details
        for (int i = 0; i < 10; i++)
        {
            // Salary input validation
            while (true)
            {
                Console.Write("Enter salary for employee " + (i + 1) + ": ");
                double salary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter years of service for employee " + (i + 1) + ": ");
                double service = Convert.ToDouble(Console.ReadLine());

                // Validate input
                if (salary > 0 && service >= 0)
                {
                    oldSalaries[i] = salary;
                    yearsOfService[i] = service;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    i--; // Decrement to retry input for same employee
                    break;
                }
            }
        }

        // Calculate bonus and new salaries
        for (int i = 0; i < 10; i++)
        {
            // Determine bonus percentage
            double bonusPercentage = (yearsOfService[i] > 5) ? 0.05 : 0.02;

            // Calculate bonus
            bonusAmounts[i] = oldSalaries[i] * bonusPercentage;
            newSalaries[i] = oldSalaries[i] + bonusAmounts[i];

            // Update totals
            totalBonus += bonusAmounts[i];
            totalOldSalary += oldSalaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Display results
        Console.WriteLine("Total Bonus Payout: " + totalBonus);
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }

    public static void Main()
    {
        CalculateEmployeeBonus();
    }
}