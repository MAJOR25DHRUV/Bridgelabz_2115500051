using System;

namespace EmployeeBonusCalculatorQuestion11
{
    public class EmployeeBonus
    {
        // Constants for bonus percentages
        private const double BONUS_RATE_ABOVE_5_YEARS = 0.05;  // 5% bonus
        private const double BONUS_RATE_BELOW_5_YEARS = 0.02;  // 2% bonus

        // Method to generate random salary and service years
        public static double[,] GenerateEmployeeData(int employeeCount)
        {
            Random random = new Random();
            double[,] employeeData = new double[employeeCount, 2];  // [salary, years]
            
            for (int i = 0; i < employeeCount; i++)
            {
                // Generate random 5-digit salary (10000-99999)
                employeeData[i, 0] = random.Next(10000, 100000);
                
                // Generate random years of service (1-10)
                employeeData[i, 1] = random.Next(1, 11);
            }
            
            return employeeData;
        }

        // Method to calculate new salary and bonus
        public static double[,] CalculateBonusAndNewSalary(double[,] employeeData)
        {
            int employeeCount = employeeData.GetLength(0);
            double[,] result = new double[employeeCount, 2];  // [newSalary, bonus]
            
            for (int i = 0; i < employeeCount; i++)
            {
                double currentSalary = employeeData[i, 0];
                double yearsOfService = employeeData[i, 1];
                
                // Calculate bonus based on years of service
                double bonusRate = (yearsOfService > 5) ? BONUS_RATE_ABOVE_5_YEARS : BONUS_RATE_BELOW_5_YEARS;
                double bonus = currentSalary * bonusRate;
                
                // Calculate new salary
                double newSalary = currentSalary + bonus;
                
                // Store results
                result[i, 0] = newSalary;
                result[i, 1] = bonus;
            }
            
            return result;
        }

        // Method to calculate totals
        public static double[] CalculateTotals(double[,] employeeData, double[,] bonusData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;
            
            for (int i = 0; i < employeeData.GetLength(0); i++)
            {
                totalOldSalary += employeeData[i, 0];
                totalNewSalary += bonusData[i, 0];
                totalBonus += bonusData[i, 1];
            }
            
            return new double[] { totalOldSalary, totalNewSalary, totalBonus };
        }
    }

    class BonusCalculator
    {
        static void TestEmployeeBonus()
        {
            const int EMPLOYEE_COUNT = 10;

            // Generate employee data
            double[,] employeeData = EmployeeBonus.GenerateEmployeeData(EMPLOYEE_COUNT);
            
            // Calculate bonus and new salary
            double[,] bonusData = EmployeeBonus.CalculateBonusAndNewSalary(employeeData);
            
            // Calculate totals
            double[] totals = EmployeeBonus.CalculateTotals(employeeData, bonusData);

            // Display results in tabular format
            Console.WriteLine("\nEmployee Bonus Calculation Results:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Emp# | Current Salary | Years | Bonus | New Salary");
            Console.WriteLine("-----+----------------+-------+--------+------------");
            
            for (int i = 0; i < EMPLOYEE_COUNT; i++)
            {
                Console.WriteLine("{0,4} | {1,14:C} | {2,5:F1} | {3,6:C} | {4,10:C}",
                    i + 1,
                    employeeData[i, 0],
                    employeeData[i, 1],
                    bonusData[i, 1],
                    bonusData[i, 0]);
            }

            // Display totals
            Console.WriteLine("\nSummary:");
            Console.WriteLine("Total Old Salary: {0:C}", totals[0]);
            Console.WriteLine("Total New Salary: {0:C}", totals[1]);
            Console.WriteLine("Total Bonus: {0:C}", totals[2]);
        }

        static void Main(string[] args)
        {
            TestEmployeeBonus();
        }
    }
}