using System; // Importing the System namespace

class Athlete {
    public static void Main(string[] args) {
        Console.WriteLine("1st SIDE"); // Prompting user for the first side
        double s1 = Convert.ToDouble(Console.ReadLine()); // Reading and converting the first side to double
        Console.WriteLine("2nd SIDE"); // Prompting user for the second side
        double s2 = Convert.ToDouble(Console.ReadLine()); // Reading and converting the second side to double
        Console.WriteLine("3rd SIDE"); // Prompting user for the third side
        double s3 = Convert.ToDouble(Console.ReadLine()); // Reading and converting the third side to double
        double perimeter = s1 + s2 + s3; // Calculating the perimeter of the triangle
        double distance = 5000; // Setting the total distance to 5000
        Console.WriteLine("Total Rounds : " + Math.Ceiling(Rounds(distance, perimeter))); // Calculating and displaying the total rounds
    }

    static double Rounds(double distance, double perimeter) {
        return distance / perimeter; // Calculating the number of rounds
    }
}