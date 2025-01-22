using System;

class Weight
{
    public static void Main(string[] args)
    {
        double weightInPounds = 150; // Example weight in pounds
        ConvertPoundsToKilograms(weightInPounds); // Calling method to convert pounds to kilograms
    }

    // Method to convert pounds to kilograms and display result
    static void ConvertPoundsToKilograms(double weightInPounds)
    {
        double weightInKg = weightInPounds * 2.2; // Conversion from pounds to kilograms
        // Displaying the result
        Console.WriteLine("The weight of the person in pounds is " + weightInPounds + " and in kg is " + weightInKg);
    }
}
