using System; // Importing System namespace for basic functionalities

class Handshake
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine()); // Taking user input for number of students

        // Calculating the maximum number of handshakes using the combination formula
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

        // Displaying the result
        Console.WriteLine("The maximum number of handshakes among " + numberOfStudents + " students is " + handshakes);
    }
}
