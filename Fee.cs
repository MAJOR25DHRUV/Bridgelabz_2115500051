using System; 

class Fee // Declaring the class for fee calculation
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        double fee = 125000; // Total course fee
        double discountPercentage = 10; // Discount percentage offered by the university
        CalculateDiscountedFee(fee, discountPercentage); // Calling the method to calculate discounted fee
    }

    // Method to calculate and display the discounted amount and final fee
    static void CalculateDiscountedFee(double fee, double discountPercentage)
    {
        double discountAmount = (fee * discountPercentage) / 100; // Calculating the discount amount
        double finalFee = fee - discountAmount; // Calculating the final fee after discount
        // Displaying the result
        Console.WriteLine("The Original Fee is INR " +fee+
                          " The Discounted Amount is INR " +discountAmount+" and the Final Fee is INR " +finalFee);
    }
}
