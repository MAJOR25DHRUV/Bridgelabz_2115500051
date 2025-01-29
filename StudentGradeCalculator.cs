using System;

// Program to manage student grades and calculate statistics
class StudentGradeCalculator
{
    // Method to generate random scores for students
    public static double[,] GenerateRandomScores(int numberOfStudents)
    {
        Random random = new Random();
        double[,] scores = new double[numberOfStudents, 3];

        // Generate random scores between 40 and 100
        for (int i = 0; i < numberOfStudents; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                scores[i, j] = random.Next(40, 101);
            }
        }
        return scores;
    }

    // Method to calculate statistics for each student
    public static double[,] CalculateStatistics(double[,] scores)
    {
        int numberOfStudents = scores.GetLength(0);
        double[,] statistics = new double[numberOfStudents, 3]; // total, average, percentage

        // Calculate statistics for each student
        for (int i = 0; i < numberOfStudents; i++)
        {
            double total = 0;
            
            // Calculate total
            for (int j = 0; j < 3; j++)
            {
                total += scores[i, j];
            }
            
            // Store statistics
            statistics[i, 0] = Math.Round(total, 2);
            statistics[i, 1] = Math.Round(total / 3, 2);
            statistics[i, 2] = Math.Round((total / 300) * 100, 2);
        }
        return statistics;
    }

    // Method to determine grade based on percentage
    public static string DetermineGrade(double percentage)
    {
        if (percentage >= 80) return "A";
        else if (percentage >= 70) return "B";
        else if (percentage >= 60) return "C";
        else if (percentage >= 50) return "D";
        else if (percentage >= 40) return "E";
        else return "R";
    }

    // Method to display scorecard
    public static void DisplayScorecard(double[,] scores, double[,] statistics)
    {
        Console.WriteLine("\nStudent Scorecard");
        Console.WriteLine("----------------");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage\tGrade");
        
        // Display each student's information
        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.Write("{0}\t", i + 1);
            
            // Display subject scores
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0}\t", scores[i, j]);
            }
            
            // Display statistics and grade
            Console.Write("{0}\t{1}\t{2}\t{3}\n", 
                statistics[i, 0],
                statistics[i, 1],
                statistics[i, 2],
                DetermineGrade(statistics[i, 2]));
        }
    }

    // Main method to run the program
    static void Main(string[] args)
    {
        Console.WriteLine("Student Grade Calculator");
        Console.WriteLine("----------------------");

        // Get number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        // Generate random scores
        double[,] scores = GenerateRandomScores(numberOfStudents);

        // Calculate statistics
        double[,] statistics = CalculateStatistics(scores);

        // Display results
        DisplayScorecard(scores, statistics);
    }
}