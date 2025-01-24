using System;

public class StudentMarksCalculator
{
    public static void CalculateStudentGrades()
    {
        // Prompt the user to input the number of students
        Console.Write("Enter number of students: ");
        int studentCount = Convert.ToInt32(Console.ReadLine());

        // Array to store marks for Physics, Chemistry, and Maths for each student
        double[,] studentMarks = new double[studentCount, 3];

        // Array to store percentages for each student
        double[] studentPercentages = new double[studentCount];

        // Array to store grades for each student
        string[] studentGrades = new string[studentCount];

        // Loop through each student to collect their marks and calculate grades
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("Enter marks for Student " + (i + 1) + ":");

            // Collect and validate Physics marks
            while (true)
            {
                Console.Write("Physics marks: ");
                double physicMarks = Convert.ToDouble(Console.ReadLine());
                if (physicMarks >= 0 && physicMarks <= 100)
                {
                    studentMarks[i, 0] = physicMarks; // Store Physics marks
                    break;
                }
                Console.WriteLine("Invalid marks. Try again. (Range: 0 to 100)");
            }

            // Collect and validate Chemistry marks
            while (true)
            {
                Console.Write("Chemistry marks: ");
                double chemistryMarks = Convert.ToDouble(Console.ReadLine());
                if (chemistryMarks >= 0 && chemistryMarks <= 100)
                {
                    studentMarks[i, 1] = chemistryMarks; // Store Chemistry marks
                    break;
                }
                Console.WriteLine("Invalid marks. Try again. (Range: 0 to 100)");
            }

            // Collect and validate Maths marks
            while (true)
            {
                Console.Write("Maths marks: ");
                double mathsMarks = Convert.ToDouble(Console.ReadLine());
                if (mathsMarks >= 0 && mathsMarks <= 100)
                {
                    studentMarks[i, 2] = mathsMarks; // Store Maths marks
                    break;
                }
                Console.WriteLine("Invalid marks. Try again. (Range: 0 to 100)");
            }

            // Calculate total marks and percentage
            double totalMarks = studentMarks[i, 0] + studentMarks[i, 1] + studentMarks[i, 2];
            studentPercentages[i] = (totalMarks / 300) * 100;

            // Assign grade based on the percentage
            if (studentPercentages[i] >= 90)
                studentGrades[i] = "A+";
            else if (studentPercentages[i] >= 80)
                studentGrades[i] = "A";
            else if (studentPercentages[i] >= 70)
                studentGrades[i] = "B";
            else if (studentPercentages[i] >= 60)
                studentGrades[i] = "C";
            else if (studentPercentages[i] >= 50)
                studentGrades[i] = "D";
            else
                studentGrades[i] = "F";
        }

        // Display the results for all students
        Console.WriteLine("\nStudent Results:");
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("Student " + (i + 1) + ":");
            Console.WriteLine("Physics: " + studentMarks[i, 0]);
            Console.WriteLine("Chemistry: " + studentMarks[i, 1]);
            Console.WriteLine("Maths: " + studentMarks[i, 2]);
            Console.WriteLine("Percentage: " + Math.Round(studentPercentages[i], 2) + "%");
            Console.WriteLine("Grade: " + studentGrades[i]);
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        // Call the method to start the program
        CalculateStudentGrades();
    }
}
