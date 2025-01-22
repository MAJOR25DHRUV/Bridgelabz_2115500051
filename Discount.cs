using System; // Importing System namespace for basic functionalities

class Discount
{
    public static void Main(string[] args)
    {
        Console.Write("Enter fee: ");
        double fee = Convert.ToDouble(Console.ReadLine()); // Taking user input for fee

        Console.Write("Enter discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine()); // Taking user input for discount percentage

        // Calculating the discount amount
        double discountAmount = (fee * discountPercent) / 100;

        // Final fee after applying the discount
        double finalFee = fee - discountAmount;

        // Displaying the result
        Console.WriteLine("The discount amount is INR " + discountAmount + " and final discounted fee is INR " + finalFee);
    }
}
