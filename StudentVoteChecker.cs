using System;

public class StudentVoteChecker
{
    public static void Main(string[] args)
    {
        // Declare array to store ages
        int[] ages = new int[10];
        
        // Get ages from user
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter age for student " + (i + 1) + ":");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            
            // Check if student can vote
            if(CanStudentVote(ages[i]))
            {
                Console.WriteLine("Student " + (i + 1) + " can vote");
            }
            else
            {
                Console.WriteLine("Student " + (i + 1) + " cannot vote");
            }
        }
    }
    
    public static bool CanStudentVote(int age)
    {
        // Check for negative age
        if(age < 0)
            return false;
            
        // Check voting age
        return age >= 18;
    }
}
