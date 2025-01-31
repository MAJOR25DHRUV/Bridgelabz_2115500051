using System;

class DateComparer
{
    static void Main()
    {
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        if (date1 < date2)
            Console.WriteLine("The first date is before the second date.");
        else if (date1 > date2)
            Console.WriteLine("The first date is after the second date.");
        else
            Console.WriteLine("Both dates are the same.");
    }
}




