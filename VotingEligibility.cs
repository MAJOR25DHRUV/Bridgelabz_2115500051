using System;  // Importing the System namespace to use Console

public class VotingEligibility
{
    // Method to check if a person can vote based on their age
    public static void CheckVotingEligibility(int age)
    {
        // Check if the person's age is greater than or equal to 18
        if (age >= 18)
        {
            // Output the result to the console
            Console.WriteLine("The person's age is " + age + " and can vote.");
        }
        else
        {
            // Output the result if the person cannot vote
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }

    // Main method, entry point of the program
    public static void Main(string[] args)
    {
        // Declare the age variable and initialize with a value
        int age = 20;  // Example age; replace with user input if needed

        // Call the CheckVotingEligibility method with the provided age
        CheckVotingEligibility(age);
    }
}
