using System; 

class TotalPrice
{
    public static void Main(string[] args)
    {
        Console.Write("Enter unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine()); // Taking user input for unit price

        Console.Write("Enter quantity to be bought: ");
        int quantity = Convert.ToInt32(Console.ReadLine()); // Taking user input for quantity

        // Calculating the total purchase price
        double totalPrice = unitPrice * quantity;

        // Displaying the result
        Console.WriteLine("The total purchase price is INR " + totalPrice + " if the quantity " + quantity + " and unit price is INR " + unitPrice);
    }
}
