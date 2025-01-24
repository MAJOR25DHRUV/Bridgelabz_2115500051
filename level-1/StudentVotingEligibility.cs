using System;

public class StudentVotingEligibility
{
    // Method to check student voting eligibility
    public static void CheckVotingEligibility()
    {
        // Array to store student ages
        int[] studentAges = new int[10];

        // Input ages for 10 students
        for (int i = 0; i < studentAges.Length; i++)
        {
            Console.Write("Enter age for student " + (i + 1) + ": ");
            studentAges[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Check voting eligibility for each student
        for (int i = 0; i < studentAges.Length; i++)
        {
            // Check for invalid (negative) ages
            if (studentAges[i] < 0)
            {
                Console.WriteLine("Student " + (i + 1) + ": Invalid age");
            }
            // Check voting eligibility
            else if (studentAges[i] >= 18)
            {
                Console.WriteLine("Student " + (i + 1) + " with age " + studentAges[i] + " can vote");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " with age " + studentAges[i] + " cannot vote");
            }
        }
    }

    public static void Main()
    {
        CheckVotingEligibility();
    }
}
