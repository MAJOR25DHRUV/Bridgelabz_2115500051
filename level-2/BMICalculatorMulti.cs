using System;

public class BMICalculatorMulti
{
    public static void CalculateBMI()
    {
        // Prompt the user to input the number of persons
        Console.Write("Enter number of persons: ");
        int personCount = Convert.ToInt32(Console.ReadLine());

        // Initialize a jagged array to store weight, height, and BMI for each person
        double[][] personData = new double[personCount][];
        for (int i = 0; i < personCount; i++)
        {
            personData[i] = new double[3];
        }

        // Create an array to store the weight status for each person
        string[] weightStatus = new string[personCount];

        // Loop through each person to collect their weight, height, and calculate BMI
        for (int i = 0; i < personCount; i++)
        {
            // Collect and validate weight input
            while (true)
            {
                Console.Write("Enter weight for person " + (i + 1) + " (kg): ");
                double weight = Convert.ToDouble(Console.ReadLine());
                if (weight > 0)
                {
                    personData[i][0] = weight; // Store weight
                    break;
                }
                Console.WriteLine("Weight must be positive. Try again.");
            }

            // Collect and validate height input
            while (true)
            {
                Console.Write("Enter height for person " + (i + 1) + " (m): ");
                double height = Convert.ToDouble(Console.ReadLine());
                if (height > 0)
                {
                    personData[i][1] = height; // Store height
                    break;
                }
                Console.WriteLine("Height must be positive. Try again.");
            }

            // Calculate BMI using the formula: BMI = weight / (height * height)
            double bmi = personData[i][0] / (personData[i][1] * personData[i][1]);
            personData[i][2] = bmi; // Store BMI

            // Determine weight status based on BMI value
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                weightStatus[i] = "Normal";
            else if (bmi >= 25 && bmi < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Display the BMI results for all persons
        Console.WriteLine("\nBMI Results:");
        for (int i = 0; i < personCount; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ":");
            Console.WriteLine("Weight: " + personData[i][0] + " kg");
            Console.WriteLine("Height: " + personData[i][1] + " m");
            Console.WriteLine("BMI: " + Math.Round(personData[i][2], 2));
            Console.WriteLine("Status: " + weightStatus[i]);
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        // Call the CalculateBMI method to start the program
        CalculateBMI();
    }
}
