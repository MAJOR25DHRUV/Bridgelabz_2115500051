using System; 

class Height 
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your height in centimeters: ");
        double cm = Convert.ToDouble(Console.ReadLine()); // Taking user input for height in centimeters

        // Converting height to feet and inches
        double totalInches = cm / 2.54; // 1 inch = 2.54 cm
        int feet = (int)(totalInches / 12); // 1 foot = 12 inches
        int inches = (int)(totalInches % 12); // Remaining inches

        // Displaying the result
        Console.WriteLine("Your Height in cm is " + cm + " while in feet is " + feet + " and inches is " + inches);
    }
}
