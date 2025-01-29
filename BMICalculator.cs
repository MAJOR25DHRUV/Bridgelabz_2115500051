using System;

public class BMICalculator
{
    public static void Main(string[] args)
    {
        // Create 2D array to store weight, height, and BMI for 10 people
        double[,] personData = new double[10, 3];
        string[] bmiStatus = new string[10];
        
        // Get input for each person
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1));
            
            Console.WriteLine("Enter weight (in kg):");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter height (in cm):");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());
            
            // Calculate BMI
            personData[i, 2] = CalculateBMI(personData[i, 0], personData[i, 1]);
            
            // Determine BMI status
            bmiStatus[i] = DetermineBMIStatus(personData[i, 2]);
        }
        
        // Display results
        Console.WriteLine("\nBMI Results:");
        Console.WriteLine("Person\tWeight\tHeight\tBMI\tStatus");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                personData[i, 0].ToString("F1") + "kg\t" +
                personData[i, 1].ToString("F1") + "cm\t" +
                personData[i, 2].ToString("F1") + "\t" +
                bmiStatus[i]
            );
        }
    }
    
    public static double CalculateBMI(double weight, double heightCm)
    {
        // Convert height to meters and calculate BMI
        double heightM = heightCm / 100.0;
        return weight / (heightM * heightM);
    }
    
    public static string DetermineBMIStatus(double bmi)
    {
        // Determine BMI status based on value
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi < 25)
            return "Normal";
        else if (bmi < 30)
            return "Overweight";
        else
            return "Obese";
    }
}
